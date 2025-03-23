using System.ComponentModel.DataAnnotations;

namespace generic_repo.Data.Model{
    public class Employee {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }
    }
}