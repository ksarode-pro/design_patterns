using generic_repo.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace generic_repo.Data
{
    public class CustomAppDbContext : DbContext
    {
        public CustomAppDbContext(DbContextOptions<CustomAppDbContext> options) : base(options)
        {

        }

        DbSet<Employee> employees { get; set; }
    }
}