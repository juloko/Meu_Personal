using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Meu_Personal.UserServices;

namespace Meu_Personal.ServicesByGym
{
    interface IService
    {
        String getName();
        String getDescrition();
        String getButtonPayment();
        Customer getClient();
        bool statusPayment();
        
    }
}
