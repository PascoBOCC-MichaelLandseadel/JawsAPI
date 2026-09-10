using System;
using System.Collections.Generic;

namespace Jaws.Data.Entities;

public partial class VwAspnetUsers2
{
    public string UserName { get; set; } = null!;

    public string ApplicationName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int PasswordFormat { get; set; }

    public string PasswordSalt { get; set; } = null!;

    public string? Email { get; set; }

    public string RoleName { get; set; } = null!;

    public bool IsLockedOut { get; set; }

    public int FailedPasswordAttemptCount { get; set; }
}
