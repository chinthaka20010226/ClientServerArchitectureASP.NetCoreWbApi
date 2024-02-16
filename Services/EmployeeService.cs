using employee_crud_back_.Exceptions;
using employee_crud_back_.Interfaces.Repositories;
using employee_crud_back_.Interfaces.Services;
using employee_crud_back_.Models.Entities;

namespace employee_crud_back_.Services
{
    public class EmployeeService(IEmployeeRepository employeeRepository) : IEmployeeService
    {
        public async Task<Employee> GetEmployeeById(int id)
        {
            if(id <= 0)
            {
                throw new InvalidArgumentException("It must be greater than zero");
            }

            var employee = await employeeRepository.GetEmployeeById(id);

            return employee ?? throw new NotFoundException($"Employee with id {id} not fond");
        }
    }
}
