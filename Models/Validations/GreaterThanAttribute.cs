using System.ComponentModel.DataAnnotations;

namespace employee_crud_back_.Models.Validations
{
    public class GreaterThanAttribute(int lowerlimit) : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is not double salary) return new ValidationResult("Salart type must be double");

            return salary >= lowerlimit ? ValidationResult.Success : new ValidationResult($"Salary must be greater than or equal to the{lowerlimit}"); 
        }
    }
}
