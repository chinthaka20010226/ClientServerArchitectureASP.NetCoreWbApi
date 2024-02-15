using employee_crud_back_.Models.Entities;

namespace employee_crud_back_.Interfaces.Repositories
{
    public interface IDepartmentRepository
    {
        Task<Department?> GetDepartmmentById(int id);
        Task<Department?> GetDepartmentByName(string name);
        Task<IEnumerable<Department>> GetDepartments();
        void InsertDepartment(Department department);
        /*
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
        */
        Task Save();
    }
}
