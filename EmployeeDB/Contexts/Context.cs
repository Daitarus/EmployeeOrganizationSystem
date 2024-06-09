using EmployeeDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDB.Contexts
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<SubordinationHierarchy> SubordinationHierarchies { get; set; }

        public Context(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
