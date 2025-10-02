using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Dependency Inversion Principle
 * A high-level module should not depend on a low-level module
 * Both should depend on abstractions
 * CustomerService  
*/
namespace SolidPrinciples.DIP
{
    internal class DIPExample
    {
        

        public interface ICustomerRepository
        {
            void Add(Customer customer);
        }

        public class CustomerRepository : ICustomerRepository
        {
            public void Add(Customer customer)
            {
                throw new NotImplementedException();
            }
        }

        public class CustomerService
        {
            private readonly ICustomerRepository _customerRepository;

            public CustomerService(ICustomerRepository customerRepository)
            {
                _customerRepository = customerRepository;
            }

            public void RegisterCustomer(Customer customer)
            {
                _customerRepository.Add(customer);
            }
        }
    }
}
