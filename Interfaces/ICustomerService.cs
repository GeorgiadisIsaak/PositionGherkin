﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(string sydipel);
    }
}
