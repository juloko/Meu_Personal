using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;

namespace Meu_Personal.Communication
{
    class Chat
    {
        private User userOwner;
        private User userFriend;
        private Stack<Message> msgs;

        public Chat(User userOwner, User userFriend)
        {
            this.userOwner = userOwner;
            this.userFriend = userFriend;

        }
        public void sendMessage(Message msg)
        {

        }
        public void deleteMessage(Message msg)
        {

        }

        public User getUserOwner()
        {
            return userOwner;
        }
        public User getUserFriend()
        {
            return userFriend;
        }
    }
}
