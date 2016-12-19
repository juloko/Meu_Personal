using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;

namespace Meu_Personal.PaymentServices
{
    class Payment
    {
        private int idPayment;
        private String idGym;
        private String idUser;
        private String idService;
        private bool statusIsPaid = false;

        public Payment(String idGym, String idUser, String idService)
        {
            this.idGym = idGym;
            this.idUser = idUser;
            this.idService = idService;
        }
        
    }
}
