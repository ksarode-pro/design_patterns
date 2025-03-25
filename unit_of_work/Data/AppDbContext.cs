using Microsoft.EntityFrameworkCore;
using unit_of_work.Model;
namespace unit_of_work.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    DbSet<Employee> employees {get; set;}
    DbSet<Department> departments {get; set;}
}