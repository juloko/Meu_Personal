using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.WorkoutServices
{
    interface IWorkout
    {
        void addExercise(Exercise exercise);

        void removeExercise(Exercise exercise);
    }
}
