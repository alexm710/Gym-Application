using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace GymModel
{
    public class CurrentUser
    {
        [Key]
        public int CurrentUserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User User { get; set; }
    }
}
