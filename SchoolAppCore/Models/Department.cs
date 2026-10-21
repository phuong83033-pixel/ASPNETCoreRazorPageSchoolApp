using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolAppCore.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [DisplayFormat(DataFormatString = "{0:N2}")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
