using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;
using Meu_Personal.WorkoutServices;

namespace Meu_Personal.AccountServices
{
    interface IAccount
    {
        void addUser(User user);

        void createNewWorkout(Workout work);

        void deleteWorkout(Workout work);
    }
}
