using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace Implementation
{
    public class CustomersService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }

        public Customer GetCustomer(string sydipel)
        {
            return _customerRepository.GetCustomer(sydipel);

        }
    }
}
