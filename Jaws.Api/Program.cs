using System.Text;
using Jaws.Api.App_Tools;
using Jaws.Data.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Swagger with Bearer auth (template convention).
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "JAWS API", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Enter the returned token with the prefix 'Bearer '",
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            Array.Empty<string>()
        }
    });
});

builder.Services.AddControllers();

// JAWS data layer.
builder.Services.AddJawsData(builder.Configuration);

// Auth options (LDAP + JWT). Secrets live in user secrets / env vars.
builder.Services.Configure<LdapOptions>(builder.Configuration.GetSection(LdapOptions.SectionName));
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(JwtOptions.SectionName));
builder.Services.AddScoped<ILdapAuthenticator, LdapAuthenticator>();
builder.Services.AddScoped<ITokenService, JwtTokenService>();

var jwt = builder.Configuration.GetSection(JwtOptions.SectionName).Get<JwtOptions>() ?? new JwtOptions();
var signingKey = string.IsNullOrEmpty(jwt.SigningKey) ? new string((char)48, 32) : jwt.SigningKey;
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(signingKey)),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidIssuer = jwt.Issuer,
        ValidAudience = jwt.Audience,
        ClockSkew = TimeSpan.Zero
    };
});
builder.Services.AddAuthorization();

// CORS for the Vue/Nuxt client (template convention: named policy).
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin", policy =>
        policy.WithOrigins("http://localhost:3000", "http://localhost:5173")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials());
});

var app = builder.Build();

AppKey.GetSection(app.Services.GetRequiredService<IConfiguration>());

// CORS must run before other middleware so preflight (OPTIONS) is not redirected.
app.UseCors("AllowSpecificOrigin");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "JAWS API v1"));
}
else
{
    // Force HTTPS only outside Development; in dev the Vue client uses http and
    // HTTPS redirection breaks the CORS preflight.
    app.UseHttpsRedirection();
}

app.UseAuthentication();
app.UseAuthorization();

// Security headers (template convention).
app.Use(async (context, next) =>
{
    context.Response.Headers.Append("X-Frame-Options", "DENY");
    context.Response.Headers.Append("Content-Security-Policy", "frame-ancestors 'none'");
    await next();
});

app.MapControllers();

app.Run();
