using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Repository
{
    public class CustomersRepository: ICustomerRepository
    {
        private List<Customer> Customers { get; set; }

        public CustomersRepository()
        {
            Customers = new List<Customer>()
            {
                new Customer(){Sydipel = "123145", EponumiaPelath = "Marvel", Afm = "23424515"},
                new Customer(){Sydipel = "52035235", EponumiaPelath = "Apple", Afm = "2142143214"},
                new Customer(){Sydipel = "141414", EponumiaPelath = "Microsoft", Afm = "13145252"}
            };
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return Customers;
        }

        public Customer GetCustomer(string sydipel)
        {
            return Customers.FirstOrDefault(x => x.Sydipel == sydipel);
        }
    }
}
