using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.WorkoutServices
{
    class Work
    {
        private Exercise exercise;
        private int rep;
        private int series;
        private long id;

        public Work(Exercise exercise, int rep, int series)
        {
            this.Exercise = exercise;
            this.Rep = rep;
            this.Series = series;
        }

        public int Rep
        {
            get
            {
                return rep;
            }

            set
            {
                rep = value;
            }
        }

        public int Series
        {
            get
            {
                return series;
            }

            set
            {
                series = value;
            }
        }

        internal Exercise Exercise
        {
            get
            {
                return exercise;
            }

            set
            {
                exercise = value;
            }
        }
    }
}
