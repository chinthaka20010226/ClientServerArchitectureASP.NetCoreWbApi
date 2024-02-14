using employee_crud_back_.Models.Validations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee_crud_back_.Models.Entities
{
    public class Employee
    {
        [Key]
        [Column("id")]
        [DisplayName("Employee ID")]
        public int Id { get; set; }

        [Column("fame"), MaxLength(30)]
        [DisplayName("Employee First Name")]
        public required string FName { get; set; }

        [Column("lname"), MaxLength(30)]
        [DisplayName("Employee Last Name")]
        public required string LName { get; set; }

        [Column("email"), MaxLength(50)]
        [DisplayName("Employee Email")]
        public required string Email { get; set; }

        [Column("dob")]
        [DisplayName("Employee Date of Birthday")]
        public required DateOnly DOB { get; set; }

        [Column("salary")]
        [DisplayName("Employee Salary")]
        [GreaterThan(0)]
        public required double Salary { get; set; }

        [Column("department_id")]
        [DisplayName("Department Id")]
        [ForeignKey("Department")]
        public required int DId { get; set; }

        public Department? Department { get; set; }
    }
}
