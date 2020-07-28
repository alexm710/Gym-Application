using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace GymModel
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        [StringLength(60)]
        public string Password { get; set; }
        [StringLength(60)]
        public string FirstName { get; set; }
        [StringLength(60)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public DateTime DateStarted { get; set; }
    }
}
