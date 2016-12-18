using Meu_Personal.AccountService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.AccountServices
{
    class Profile_Comercial
    {
        private String name;
        private String city;
        private Rating rating;

        Profile_Comercial(String name, String city)
        {
            rating = new Rating();
            this.name = name;
            this.city = name;
        }

        public void addNewRating(double grade, Coment coment)
        {
            rating.addNewRating(grade, coment);
        }
    }
}
