﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GymModel
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<TrainingProgram> TrainingPrograms { get; set; }
    }
}
