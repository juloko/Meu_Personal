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
        String getButtonPayment();
        bool statusPayment();
        bool notifyParts();
        Gym searchGymById();
        User searchUserById();
        Payment searchPaymentById();
        List<Gym> searchGymByName();
        List<User> searchUserByName();
    }
}
