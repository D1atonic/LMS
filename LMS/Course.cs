using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMS
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public DateTime StartDay { get; set; }
        public DateTime EndDay { get; set; }
        public int Schedule { get; set; }
        public string? Description { get; set; }
        public string Link { get; set; }
        public string? Security { get; set; }
        [ForeignKey("Username")]
        public string Username { get; set; }
        [NotMapped]
        public virtual ICollection<User>? Users { get; set; }
    }
}
