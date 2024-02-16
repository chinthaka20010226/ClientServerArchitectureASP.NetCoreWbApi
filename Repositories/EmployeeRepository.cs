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

        public async Task<Employee?> GetEmployeeByFirstName(string fName)
        {
            return await Employee.FirstOrDefaultAsync(employee => employee.FName == fName);
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await Employee.Include("Department").ToListAsync();
        }

        public void InsertEmployee(Employee employee)
        {
            Employee.Add(employee);
        }

        public async Task Save()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
