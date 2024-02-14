using employee_crud_back_.Data;
using employee_crud_back_.Interfaces.Repositories;
using employee_crud_back_.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace employee_crud_back_.Repositories
{
    public class DepartmentRepository(DataContext dataContext) : IDepartmentRepository
    {
        private DbSet<Department> Department { get; set; } = dataContext.Departments;

        public async Task<Department?> GetDepartmmentById(int id)
        {
            return await Department.FindAsync(id);
        }

        public async Task Save()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
