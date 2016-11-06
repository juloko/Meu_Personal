using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.WorkoutServices
{
    class Works : Work
    {
        private Exercise exercise2;
       
        public Works(Exercise exercise1, Exercise exercise2, int rep, int series) : base(exercise1, rep, series)
        {
            this.exercise2 = exercise2;
        }

        public Works(Exercise exercise2, Work work) : base(work.Exercise, work.Rep, work.Series)
        {
            this.exercise2 = exercise2;
        }
    }
}
