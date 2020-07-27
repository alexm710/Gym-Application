using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;
namespace GymModel

{
    public class WeeklyProgress
    {
        public bool WeeklyProgressCheck { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } 
    }
}
