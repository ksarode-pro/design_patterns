using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace unit_of_work.Model;

public class EmployeeDTO
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Employee name is mandatory")]
    [Display(Name = "Employee Name")]
    public string EmployeeName { get; set; }
    [Required(ErrorMessage = "Department Id is mandatory")]
    [Display(Name = "Department Id")]
    [ForeignKey("Employee")]
    public int DepartmentId { get; set; }
    public Department Department {get;set;}
}
