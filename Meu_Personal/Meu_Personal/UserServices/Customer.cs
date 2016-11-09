using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.UserServices
{
    public class Customer : User
    {
        //Genarate a new standart user
        public Customer(String username, String password, String email, String gender) : base(username, password, email)
        {

        }
    }
}
