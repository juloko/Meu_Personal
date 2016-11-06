using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gym_JM_final.UserServices;
using App_Gym_JM_final.WorkoutServices;

namespace App_Gym_JM_final.AccountServices
{
    interface IAccount
    {
        void addUser(User user);

        void createNewWorkout(Workout work);

        void deleteWorkout(Workout work);
    }
}
