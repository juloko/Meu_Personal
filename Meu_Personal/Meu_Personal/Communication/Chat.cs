using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gym_JM_final.UserServices;

namespace App_Gym_JM_final.Communication
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
