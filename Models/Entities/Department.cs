using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employee_crud_back_.Models.Entities
{
    public class Department
    {
        [Key]
        [Column("id")]
        [DisplayName("Department ID")]
        public int Id { get; set; }

        [Column("name"), MaxLength(20)]
        [DisplayName("DepartmentName")]
        public required string Name { get; set; }
    }
}
