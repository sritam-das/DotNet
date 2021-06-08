using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubDemo;
using NUnit.Framework;
using NSubstitute;

namespace NSubDemo.Tests
{
    [TestFixture]
    class CustomerServicesTests
    {
        [Test]
        public void WhenGetFullNameExecutesReturnsFullName()
        {
            // arrange
            ICustomerRepository customerRepository = Substitute.For<ICustomerRepository>();
            CustomerServices customerServicesObj = new CustomerServices(customerRepository);
            customerRepository.getCustomerById(1).Returns(new Customer
            {
                Customerid = 1,
                Firstname="Sritam",
                LastName="Das"
            });
            string fullName = string.Empty;

            // act
            fullName = customerServicesObj.GetFullName(1);

            // assert
            Assert.That(fullName, Is.EqualTo("Customer Name is:Sritam Das"));
            

        }
        [Test]
        public void GetCountOfCustomers()
        {
            ICustomerRepository customerRepository = Substitute.For<ICustomerRepository>();
            CustomerServices customerServicesObj = new CustomerServices(customerRepository);
            customerRepository.GetCount().Returns(3);
            int count = 0;
            count = customerServicesObj.GetCount();
            Assert.That(count, Is.EqualTo(3));
        }
        [Test]
        public void GetCountOfCustomersint()
        {
            ICustomerRepository customerRepository = Substitute.For<ICustomerRepository>();
            CustomerServices customerServicesObj = new CustomerServices(customerRepository);
            customerRepository.GetCount().Returns(1);
            int count;
            count = customerServicesObj.GetCount();
            Assert.That(customerServicesObj.GetCount(), Is.TypeOf<int>());
        }
    }
}
