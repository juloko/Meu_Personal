using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.WorkoutServices
{
    interface IWorkout
    {
        void addExercise(Exercise exercise);

        void removeExercise(Exercise exercise);
    }
}
