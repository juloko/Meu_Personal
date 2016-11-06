using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Gym_JM_final.UserServices
{
    public class Customer : User
    {
        //Genarate a new standart user
        public Customer(String username, String password, String email, String gender) : base(username, password, email)
        {

        }
    }
}
