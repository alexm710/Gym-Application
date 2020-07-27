using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymModel
{
    public class GymContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<TrainingProgram> TrainingProgram { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=GymApplication;");
    }
}