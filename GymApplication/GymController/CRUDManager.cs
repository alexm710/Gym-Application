using System;
using System.Collections.Generic;
using System.Linq;
using GymController;
using GymModel;
using Microsoft.EntityFrameworkCore;

namespace GymController
{
    public class CRUDManager
    {
        public User CurrentUser { get; set; }
        public TrainingProgram Training { get; set; }

        static void Main(string[] args)
        {
            CRUDManager crud = new CRUDManager();
            crud.CreateTraining("HIIT", "intermediate", "4x10 Squats, 2x10 incline press ups, 2x10 decline pressups");
           
        }

        public void CreateTraining(string trainingType, string difficulty, string dailyPlan)
        {
            using (var db = new GymContext())
            {
                db.Add(new TrainingProgram
                {
                    TrainingType = trainingType,
                    Difficulty = difficulty,
                    DailyPlan = dailyPlan
                });
                db.SaveChanges();
            }
        }
        public static List<TrainingProgram> RetrieveTraining()
        {
            using var db = new GymContext();
            return db.TrainingProgram.ToList();
        }
        public void Delete()
        {
            using (var db = new GymContext())
            {
                db.Remove(Training);
                db.SaveChanges();
            }
        }

        public void SetSelectedTraining(object selectedTraining)
        {
            Training = (TrainingProgram)selectedTraining;
        }

        //public void Update(string trainingType, string difficulty, string dailyPlan)
        //{
        //    using (var db = new GymContext())
        //    {
        //        var training = db.TrainingProgram.Where(u => u.UserId == CurrentUser.UserId).Include(t => t.TrainingType).FirstOrDefault();

        //        training.TrainingType.Add(
        //            new TrainingProgram
        //            {
        //                TrainingType = trainingType,
        //                Difficulty = difficulty,
        //                DailyPlan = dailyPlan
        //            });
        //        db.SaveChanges();
        //    }

        }
}