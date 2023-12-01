using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Award
    {
        [Key]
        public int AwardId { get; set; }
        public int CompetitionId { get; set; }
        public int StudentId { get; set; }
        public string Remarks { get; set; }

        public Competition Competition { get; set; } // Navigation property for Competition
        public Student Student { get; set; } // Navigation property for Student
    }

}
