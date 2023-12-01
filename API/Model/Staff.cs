using System.ComponentModel.DataAnnotations;

namespace API.Model
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public int UserId { get; set; }
        public DateTime JoinedDate { get; set; }
        public string HandlesClass { get; set; }
        public string HandlesSubject { get; set; }
        public string Remarks { get; set; }

        public User User { get; set; } // Navigation property for User
    }

}
