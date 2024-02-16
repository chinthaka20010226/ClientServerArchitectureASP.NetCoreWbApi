using employee_crud_back_.Data;
using employee_crud_back_.Interfaces.Repositories;
using employee_crud_back_.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employee_crud_back_.Repositories
{
    public class EmployeeRepository(DataContext dataContext) : IEmployeeRepository
    {
        private DbSet<Employee> Employee { get; set; } = dataContext.Employees;

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await Employee.FindAsync(id);
        }

        public async Task Save()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
