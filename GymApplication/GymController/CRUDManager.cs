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
            //crud.CreateTraining("HIIT", "intermediate", "4x10 Squats, 2x10 incline press ups, 2x10 decline pressups");
            //crud.Delete(6);
            //crud.Update("HIIT", "beginner", "4x10 burpees, 2x10 squats");
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

        public List<TrainingProgram> GetExercise()
        {
            using (var db = new GymContext())
            {
                var exercises = db.TrainingProgram.ToList();
                return exercises;
            }
        }
        public void Delete(int trainingId)
        {
            using (var db = new GymContext())
            {
                Training = db.TrainingProgram.Where(t => t.TrainingId == trainingId).FirstOrDefault();
                db.Remove(Training);
                db.SaveChanges();
            }
        }

        public void Update(string trainingType, string difficulty, string dailyPlan)
        {
            using (var db = new GymContext())
            {
                var training = db.TrainingProgram.Where(t => t.TrainingId == CurrentUser.UserId).FirstOrDefault();

                training.TrainingType = trainingType;
                training.Difficulty = difficulty;
                training.DailyPlan = dailyPlan;
                db.SaveChanges();
                //var training = db.TrainingProgram.Where(u => u.UserId == CurrentUser.UserId).FirstOrDefault()

                //Training = db.TrainingProgram.Where(t => t.TrainingId == trainingId).FirstOrDefault();
                //Training.TrainingType = trainingType;
                //Training.Difficulty = difficulty;
                //Training.DailyPlan = dailyPlan;
            }
        }
        public void SetSelectedTraining(object selectedTraining)
        {
            Training = (TrainingProgram)selectedTraining;
        }

    }
}