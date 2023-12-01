using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class ExhibitionPosting
    {
        [Key]
        public int ExhibitionPostingId { get; set; }
        public int ExhibitionId { get; set; }
        public int StudentId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Quotation { get; set; }
        public string Story { get; set; }
        public string Poem { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } // New, Under Review, Accepted, Rejected, Sold, Returned
        public decimal Price { get; set; }
        public string Remarks { get; set; }

        public Exhibition Exhibition { get; set; } // Navigation property for Exhibition
        public Student Student { get; set; } // Navigation property for Student
    }

}
