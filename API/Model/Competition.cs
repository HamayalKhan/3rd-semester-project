using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Competition
    {
        [Key]
        public int CompetitionId { get; set; }
        public int StaffId { get; set; }
        public string Title { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Status { get; set; }
        public string AwardDetails { get; set; }

        public Staff Staff { get; set; } // Navigation property for Staff
    }

}
