using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;

namespace Meu_Personal.Communication
{
    class Chat_Personal : Chat
    {
        public Chat_Personal(User userOwner, User userFriend) : base(userOwner, userFriend)
        {
        }
    }
}
