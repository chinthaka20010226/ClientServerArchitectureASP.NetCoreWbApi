using employee_crud_back_.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employee_crud_back_.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public required DbSet<Employee> Employees { get; set; }

        public required DbSet<Department> Departments { get; set; }
    }
}
