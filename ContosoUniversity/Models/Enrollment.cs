namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        // Primary key
        public int EnrollmentID { get; set; }

        // Foreign keys
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        // ? means Grade is nullable
        public Grade? Grade { get; set; }

        // Navigation properties. Why have these as well as Foreign keys?
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}