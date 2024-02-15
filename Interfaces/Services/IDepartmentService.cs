using employee_crud_back_.Models.Entities;

namespace employee_crud_back_.Interfaces.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartmentById(int id);
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> InsertDepartment(Department department);
        /*
        Task<Department> UpdateDepartment(Department department);
        Task<Department> DeleteDepartment(int id);
        */
    }
}
