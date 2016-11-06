using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gym_JM_final.UserServices;
using App_Gym_JM_final.WorkoutServices;

namespace App_Gym_JM_final.AccountServices
{
    class Personal_Account : Account
    {
        private List<Customer> clients;
        private int qntClients;
        private Profile profile;
        private List<Gym> gyms;

        public List<Customer> Clients
        {
            get
            {
                return clients;
            }

            set
            {
                clients = value;
            }
        }

        public int QntClients
        {
            get
            {
                return qntClients;
            }

            set
            {
                qntClients = value;
            }
        }

        internal Profile Profile
        {
            get
            {
                return profile;
            }

            set
            {
                profile = value;
            }
        }

        internal List<Gym> Gyms
        {
            get
            {
                return gyms;
            }

            set
            {
                gyms = value;
            }
        }

        public Personal_Account(User user) : base(user)
        {
        }

    }
}
