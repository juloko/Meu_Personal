using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;

namespace Meu_Personal.Communication
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
