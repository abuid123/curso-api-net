using System.ComponentModel.DataAnnotations;

namespace MiBackendCampus.Models.DataModels
{
    public class Student : BaseEntity
    {        
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
