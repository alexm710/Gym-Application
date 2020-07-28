using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace GymModel
{
    public class UserTrainingJunction
    {
        public int TrainingId { get; set; }
        public int UserId { get; set; }
        public TrainingProgram TrainingProgram { get; set; }
        public User User { get; set; }
    }
}
