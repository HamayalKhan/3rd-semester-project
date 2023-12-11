﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    public class Award
    {
        [Key]
        public int AwardId { get; set; }
        public int CompetitionId { get; set; }
        public int StudentId { get; set; }
        public string Remarks { get; set; }
        [ForeignKey("CompetitionId ")]
        public Competition Competition { get; set; } // Navigation property for Competition
        [ForeignKey("StudentId")]

        public Student Student { get; set; } // Navigation property for Student
    }

}
