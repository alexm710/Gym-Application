using System;
using System.Collections.Generic;
using System.Text;

namespace GymModel
{
    public partial class TrainingProgram
    {
        public override string ToString()
        {
            return $"{TrainingType}, {Difficulty}, {DailyPlan}";
        }
    }
}
