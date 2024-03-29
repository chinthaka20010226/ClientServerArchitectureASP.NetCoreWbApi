﻿using employee_crud_back_.Data;
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

        public async Task<Department?> GetDepartmentByName(string name)
        {
            return await Department.FirstOrDefaultAsync(department => department.Name == name);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await Department.ToListAsync();
        }

        public void InsertDepartment(Department department)
        {
            Department.Add(department);
        }

        public void UpdateDepartment(Department department)
        {
            Department.Update(department);
        }

        public async void DeleteDepartment(int id)
        {
            var department = await Department.FindAsync(id);

            if (department != null)
            {
                Department.Remove(department);
            }
        }

        public async Task Save()
        {
            await dataContext.SaveChangesAsync();
        }
    }
}
