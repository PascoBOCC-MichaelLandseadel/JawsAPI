using Microsoft.EntityFrameworkCore;

namespace Jaws.Api.Services;

public interface IBaseService<T>
{
    Task<T?> Get(int id);
    Task<List<T>> GetList();
    Task<string> Create(Models.IBaseModel obj);
    Task<string> Update(Models.IBaseModel obj);
    Task<string> Remove(int id);
}

/// <summary>
/// Generic CRUD service (template convention) with soft-delete (TsRemoved) and
/// audit timestamps. For new API-owned entities implementing IBaseModel.
/// </summary>
public abstract class BaseService<T> : IBaseService<T> where T : class
{
    protected readonly DbContext _context;
    private readonly string _objectName;
    private readonly DbSet<T> _dbSet;
    protected readonly ILogger _logger;

    protected BaseService(ILogger logger, DbContext context, string objectName = "")
    {
        _logger = logger;
        _context = context;
        _objectName = objectName;
        _dbSet = context.Set<T>();
    }

    public virtual Task<T?> Get(int id) =>
        _dbSet.SingleOrDefaultAsync(r => ((Models.IBaseModel)r).Id == id);

    public virtual Task<List<T>> GetList() =>
        _dbSet.Where(r => ((Models.IBaseModel)r).TsRemoved == null).ToListAsync();

    public virtual async Task<string> Create(Models.IBaseModel obj)
    {
        try
        {
            if (_dbSet.Find(obj.Id) != null) return $"{_objectName} with that Id already exists.";
            obj.TsCreated = DateTime.Now;
            obj.TsUpdated = DateTime.Now;
            obj.TsRemoved = null;
            _dbSet.Add((T)obj);
            await _context.SaveChangesAsync();
            return "";
        }
        catch (Exception ex) { return LogEx(ex); }
    }

    public virtual async Task<string> Update(Models.IBaseModel obj)
    {
        try
        {
            var dbObj = (Models.IBaseModel?)_dbSet.Find(obj.Id);
            if (dbObj == null) return $"{_objectName} was not found.";
            obj.TsCreated = dbObj.TsCreated;
            obj.TsUpdated = DateTime.Now;
            _context.Entry(dbObj).CurrentValues.SetValues(obj);
            await _context.SaveChangesAsync();
            return "";
        }
        catch (Exception ex) { return LogEx(ex); }
    }

    public virtual async Task<string> Remove(int id)
    {
        try
        {
            var obj = (Models.IBaseModel?)_dbSet.Find(id);
            if (obj == null) return $"{_objectName} was not found.";
            obj.TsRemoved = obj.TsRemoved == null ? DateTime.Now : null;
            await _context.SaveChangesAsync();
            return "";
        }
        catch (Exception ex) { return LogEx(ex); }
    }

    protected virtual string LogEx(Exception ex)
    {
        _logger.LogError("Message: {Message}", ex.Message);
        return "Error encountered.  The exception was logged.";
    }
}