using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App_Gym_JM_final.UserServices;

namespace App_Gym_JM_final.Communication
{
    class Message
    {
        private User userSender;
        private String msg;

        private User userDest;
        private Boolean hasBeenSeen;
        private Boolean hasBeenReceived;
        private DateTime timeSended;

        public Message(User userSender, User userDest, String msg)
        {
            timeSended = DateTime.Now;

            this.userDest = userDest;
            this.userSender = userSender;
            this.msg = msg;
        }

    }
}
