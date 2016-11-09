using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.UserServices
{
    class Person : User
    {
        private String gender;

        public Person(String username, String password, String email, String gender) : base(username, password, email)
        {
            setGender(gender);
        }

        private bool isValidGender(string nGender)
        {
            if (nGender.ToLower() == "male" || nGender.ToLower() == "female")
            {
                return true;
            }
            else
                return false;
        }

        public void setGender(String nGender)
        {
            if (isValidGender(nGender) == true)
            {
                gender = nGender;
            }
            else
                throw new Exception("");
        }
        public String getGender()
        {
            return gender;
        }
    }
}
