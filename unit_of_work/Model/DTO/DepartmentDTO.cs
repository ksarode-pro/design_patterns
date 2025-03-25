using System.ComponentModel.DataAnnotations;

namespace unit_of_work.Model;

public class DepartmentDTO{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Department name is mandatory")]
    [Display(Name = "Display Name")]
    public string DepartmentName { get; set; }
}
