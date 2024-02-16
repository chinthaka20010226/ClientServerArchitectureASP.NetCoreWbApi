using employee_crud_back_.Models.Entities;

namespace employee_crud_back_.Interfaces.Repositories
{
    public interface IEmployeeRepository
    {
        Task<Employee?> GetEmployeeById(int id);
        Task<Employee?> GetEmployeeByFirstName(string fName);
        Task<IEnumerable<Employee>> GetEmployees();
        void InsertEmployee(Employee employee);
        /*
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        */
        Task Save();

    }
}
