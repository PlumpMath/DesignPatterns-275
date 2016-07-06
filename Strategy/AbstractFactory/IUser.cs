﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    interface IUser
    {
        void Insert(User user);
        User GetUser();
    }
}