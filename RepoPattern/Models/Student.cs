using System.ComponentModel.DataAnnotations;

namespace RepoPattern.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "First name cannot be longer than 10 characters.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(12, ErrorMessage = "First name cannot be longer than 12 characters.")]
        public string LastName { get; set; }

        [Required]
        [Range(18, 80)]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        //public virtual ICollection<Student> Students { get; }

    }
}
