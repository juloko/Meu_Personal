﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meu_Personal.UserServices
{
    public class Trainer : User
    {

        public Trainer(User u) : base(u.getUsername(), u.getPassword(), u.getEmail(), u.getDateRegister())
        {

        }

    }
}