using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Exhibition
    {
        [Key]
        public int ExhibitionId { get; set; }
        public int StaffId { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Staff Staff { get; set; } // Navigation property for Staff
    }

}
