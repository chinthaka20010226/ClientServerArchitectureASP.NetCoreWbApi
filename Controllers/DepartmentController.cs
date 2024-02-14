using employee_crud_back_.Exceptions;
using employee_crud_back_.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace employee_crud_back_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController(IDepartmentService departmentService) : ControllerBase
    {
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            try
            {
                var department = await departmentService.GetDepartmentById(id);
                return Ok(department);
            }
            catch (NotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500);
            }
        }
    }
}
