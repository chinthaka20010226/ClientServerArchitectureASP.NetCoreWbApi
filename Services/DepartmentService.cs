using employee_crud_back_.Exceptions;
using employee_crud_back_.Interfaces.Repositories;
using employee_crud_back_.Interfaces.Services;
using employee_crud_back_.Models.Entities;

namespace employee_crud_back_.Services
{
    public class DepartmentService(IDepartmentRepository departmentRepository) : IDepartmentService
    {
        public async Task<Department> GetDepartmentById(int id)
        {
            if (id <= 0)
            {
                throw new InvalidArgumentException("It must be greater than zero");
            }

            var department = await departmentRepository.GetDepartmmentById(id);

            return department ?? throw new NotFoundException($"department with id {id} not found");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await departmentRepository.GetDepartments();
        }

        public async Task<Department> InsertDepartment(Department newDepartment)
        {
            departmentRepository.InsertDepartment(newDepartment);
            await departmentRepository.Save();

            var insertDepartment = await departmentRepository.GetDepartmentByName(newDepartment.Name);

            return insertDepartment ?? throw new NotFoundException($"Department with name {newDepartment.Name} not found");
        }

        public async Task<Department> UpdateDepartment(Department newDepartment)
        {
            var departmentToUpdate = await departmentRepository.GetDepartmmentById(newDepartment.Id) ??
                throw new NotFoundException($"Department with id {newDepartment.Id} not found");

            departmentToUpdate.Name = newDepartment.Name == "" ? departmentToUpdate.Name : newDepartment.Name;


            departmentRepository.UpdateDepartment(departmentToUpdate);
            await departmentRepository.Save();

            return departmentToUpdate;
        }

        public async Task<Department> DeleteDepartment(int id)
        {
            if (id < 0)
            {
                throw new InvalidArgumentException("Id must be greater than zero");
            }

            var departmentToDelete = await departmentRepository.GetDepartmmentById(id) ??
                throw new NotFoundException($"Department with id {id} not found");

            departmentRepository.DeleteDepartment(id);
            await departmentRepository.Save();

            return departmentToDelete;
        }
    }
}
