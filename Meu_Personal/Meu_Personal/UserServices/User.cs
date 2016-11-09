using System;

namespace Meu_Personal.UserServices
{
    public class User
    {
        private String username;
        private String password;
        private String email;
        private int id { get; }
        private DateTime dateRegister;

        public User(String username, String password, String email)
        {
            this.username = username;
            this.password = password;
            this.email = email;
            this.dateRegister = DateTime.Today;
        }

        public User(String username, String password, String email, DateTime date)
        {
            this.username = username;
            setPassword(password);
            this.email = email;
            this.dateRegister = date;

        }

        public String getUsername()
        {
            return username;
        }
        public String getPassword()
        {
            return password;
        }
        public String getEmail()
        {
            return email;
        }
        public DateTime getDateRegister()
        {
            return dateRegister;
        }

        public void setUsername(String nUsername)
        {
            if (isValidUsername(nUsername) == true)
            {
                username = nUsername;
            }
            else
            {
                throw new Exception("Nome invalido");
            }
        }

        public void setPassword(String nPassword)
        {
            if (isValidPassword(nPassword) == true)
            {
                username = nPassword;
            }
            else
                throw new Exception("Senha invalida");
        }
        
        

        private Boolean isValidPassword(String nPassword)
        {
            if (nPassword.Length == 0 || nPassword == "" || nPassword == null)
            {
                return false;
            }
            else
                return true;
        }
        private Boolean isValidUsername(String nUsername)
        {
            if (nUsername.Length == 0 || nUsername == "" || nUsername == null)
            {
                return false;
            }
            else
                return true;
        }
    }
}