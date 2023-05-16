using Microsoft.EntityFrameworkCore;

namespace EfCodeFirst.Models
{
    public class HydContext : DbContext
    {
        public HydContext()
        {
        }

        public HydContext(DbContextOptions<HydContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;

    }
}
