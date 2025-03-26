using unit_of_work.Model;

namespace unit_of_work.Data;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    public AppDbContext _dbContext;
    public IGenericRepo<Employee> employeeRepo {get;}
    public IGenericRepo<Department> departmentRepo {get;}

    public Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction transaction;
    public UnitOfWork(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        employeeRepo = new GenericRepo<Employee>(_dbContext);
        departmentRepo = new GenericRepo<Department>(_dbContext);
    }

    public async Task BeginTransationAsync()
    {
        this.transaction = await _dbContext.Database.BeginTransactionAsync();
    }
    public async Task<bool> CommitAsync()
    {
        bool result = false;
        try
        {
            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
            result = true;
        }
        catch(Exception ex)
        {
            RollbackAsync();
            result = false;
        }
        finally
        {
            await transaction.DisposeAsync();
        }
        return result;
    }
    private async void RollbackAsync()
    {
        await transaction.RollbackAsync();
    }

    public void Dispose()
    {
        _dbContext.DisposeAsync();
    }
}

