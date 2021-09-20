﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;

namespace Data.Repository
{
    interface ILoginRepo
    {
        void AddCust(LoginCustomer cust);
        void Save();
    }
}
