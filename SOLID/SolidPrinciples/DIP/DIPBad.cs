using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.DIP
{
    internal class DIPBad
    {

        /**
         *  Here CustomerService directly depends on the concrete CustomerRepository
         *  Violating the DIP principle
        */
        public class CustomerRepository
        {
            public void Add(Customer customer)
            {

            }

            public class CustomerService
            {
                private readonly CustomerRepository _customerRepository = new();

                public void RegisterCustomer(Customer customer)
                {
                    _customerRepository.Add(customer);
                }
            }
        }
    }
}
