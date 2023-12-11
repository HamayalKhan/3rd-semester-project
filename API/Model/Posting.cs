using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Posting
    {
        [Key]
        public int PostingId { get; set; }
        public int StudentId { get; set; }
        public int CompetitionId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Quotation { get; set; }
        public string Story { get; set; }
        public string Poem { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Mark { get; set; }
        public string Remarks { get; set; }

        public Student Student { get; set; } // Navigation property for Student
        /*public Competition Competition { get; set; }*/ // Navigation property for Competition
    }

}
