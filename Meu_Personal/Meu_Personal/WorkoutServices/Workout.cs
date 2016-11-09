using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.WorkoutServices
{
    class Workout : IWorkout
    {
        private List<Exercise> exercises = new List<Exercise>();
        private int qntExercises;

        public Workout()
        {

        }

        public int QntExercises
        {
            get
            {
                return qntExercises;
            }

            set
            {
                qntExercises = value;
            }
        }

        internal List<Exercise> Exercises
        {
            get
            {
                return exercises;
            }

            set
            {
                exercises = value;
            }
        }

        private void addExerciseLocal(Exercise exer)
        {
            exercises.Add(exer);
            qntExercises += 1;
        }

        private void removeExerciseByName(String exer)
        {
            for (int i = 0; i < qntExercises; i++)
            {
                if (exercises[i].getName().ToLower() == exer.ToLower())
                {
                    exercises.Remove(exercises[i]);
                    qntExercises -= 1;
                }
            }
        }

        void IWorkout.addExercise(Exercise exercise)
        {
            addExerciseLocal(exercise);
        }

        void IWorkout.removeExercise(Exercise exercise)
        {
            removeExerciseByName(exercise.getName());
        }
    }
}
