using System.ComponentModel.DataAnnotations;

namespace generic_repo.Data.DTO{
    class NewEmployeeDto {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}