namespace employee_crud_back_.DTO
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public required string FName { get; set; }
        public required string LName { get; set; }
        public required string Email { get; set; }
        public required string DOB { get; set; }
        public required double Salary { get; set; }
        public required int DId { get; set; }
    }
}
