using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSubDemo
{
    public class CustomerServices
    {
        private ICustomerRepository _customerRepository;
        public CustomerServices (ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;     
        }
        public string GetFullName(int custId)
        {
            Customer customerObj = _customerRepository.getCustomerById(custId);
            return string.Format("Customer Name is:{0} {1}", customerObj.Firstname, customerObj.LastName);
        }


        /* Assignment: Create a method in the CustomerServices that returns the count of customers.
         * Create 2 test cases that check whether you are 
         * getting an integer value returned and another that returns the count of customers */
        public int GetCount()
        {
            int GetCount = _customerRepository.GetCount();
            return GetCount;
        }
    }
}
