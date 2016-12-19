using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;
using Meu_Personal.WorkoutServices;

namespace Meu_Personal.AccountService
{
    class Client_Account : Account
    {
        private List<Workout> workouts;
        private int qntWorkouts;
        private Profile profile;

        public Client_Account(User user) : base(user)
        {
        }

        public List<Workout> getWorkouts()
        {
            return workouts;
        }

        public void addWorkout(Workout work)
        {
            workouts.Add(work);
            qntWorkouts += 1;
        }
        public void rmvWorkout(Workout work)
        {
            foreach(Workout i in workouts)
            {
                if(i == work)
                {
                    workouts.Remove(work);
                    qntWorkouts -= 1;
                }
            }
        }
        public int getQntWorkouts()
        {
            return qntWorkouts;
        }
        public Profile getProfile()
        {
            return profile;
        }
        public void setProfile(Profile profile)
        {
            this.profile = profile;
        }
    }
}
