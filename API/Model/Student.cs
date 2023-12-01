namespace API.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public int UserId { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string Remarks { get; set; }

        public User User { get; set; } // Navigation property for User
    }

}
