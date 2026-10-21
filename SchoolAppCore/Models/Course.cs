using System.ComponentModel.DataAnnotations;

namespace SchoolAppCore.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [Range(1, 10)]
        public int Credits { get; set; }

        [Display(Name = "Department")]
        public int? DepartmentID { get; set; }

        public Department? Department { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
