using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.AccountService
{
    class Rating
    {
        private List<Coment> coments;
        private double grade;
        private int numRatings;

        public void addNewRating(double ngrade, Coment coment)
        {
            if(ngrade < 5 || ngrade >= 0)
            {
                grade = ((grade * numRatings) + grade) / numRatings + 1;
                numRatings += 1;
                coments.Add(coment);
            }
            
        }
    }
}
