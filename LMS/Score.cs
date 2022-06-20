namespace LMS
{
    public class Score
    {
        public int CourseID { get; set; }
        public string UserName { get; set; }
        public double Scores { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }
    }
}
