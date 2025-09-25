using System.ComponentModel.DataAnnotations;
using static Zoo.Data.lib.Enums;

namespace Zoo.Data.Entities
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public EmployeeRoles Role {  get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
