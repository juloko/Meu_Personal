using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.Communication;
using Meu_Personal.UserServices;

namespace Meu_Personal.AccountServices
{
    class Manager_Account : Account
    {
        private Profile_Comercial profile_gym;
        private List<Personal_Account> trainers;
        private Chat chats;
        private List<Register> registers;

        public Manager_Account(User user): base(user)
        {

        }

        internal Profile_Comercial Profile_gym
        {
            get
            {
                return profile_gym;
            }

            set
            {
                profile_gym = value;
            }
        }

        internal List<Personal_Account> Trainers
        {
            get
            {
                return trainers;
            }

            set
            {
                trainers = value;
            }
        }

        internal Chat Chats
        {
            get
            {
                return chats;
            }

            set
            {
                chats = value;
            }
        }

        public List<Register> Registers
        {
            get
            {
                return registers;
            }

            set
            {
                registers = value;
            }
        }
    }
}
