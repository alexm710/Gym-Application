﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GymModel
{
    public class TrainingProgram
    {
        [Key]
        public int TrainingId { get; set; }
        public int UserId { get; set; }
        public int TrainingType { get; set; }
        public string Difficulty { get; set; }
    }
}
    