using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GymModel
{
    public partial class TrainingProgram
    {
        [Key]
        public int TrainingId { get; set; }
        public int UserId { get; set; }
        public string TrainingType { get; set; }
        public string Difficulty { get; set; }
        public string DailyPlan { get; set; }
    }
}
    