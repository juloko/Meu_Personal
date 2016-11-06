using System;
using System.Collections.Generic;
using App_Gym_JM_final.UserServices;
using App_Gym_JM_final.Communication;

namespace App_Gym_JM_final.AccountServices
{
    class Account
    {
        private User user;
        private List<Chat> chats;

        public Account(User user)
        {
            this.user = user;
        }
    }
}
