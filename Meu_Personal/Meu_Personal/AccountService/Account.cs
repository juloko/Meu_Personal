using System;
using System.Collections.Generic;
using Meu_Personal.UserServices;
using Meu_Personal.Communication;

namespace Meu_Personal.AccountServices
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
