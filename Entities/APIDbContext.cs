using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Entities
{
    public class APIDbContext: DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) { }
        public DbSet<Department> Departments
        {
            get;
            set;
        }
        public DbSet<Employee> Employees
        {
            get;
            set;
        }
    }
}
