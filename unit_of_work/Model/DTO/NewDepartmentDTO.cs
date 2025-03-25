using System.ComponentModel.DataAnnotations;

namespace unit_of_work.Model;

public class NewDepartmentDTO{
    [Required(ErrorMessage = "Department name is mandatory")]
    [Display(Name = "Display Name")]
    public string DepartmentName { get; set; }
}