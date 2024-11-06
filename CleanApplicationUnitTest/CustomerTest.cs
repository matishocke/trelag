using Abstraction.IModels;
using Abstraction.IRepository;
using Repository.Repository;
using Repository.Repository.Mockeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanApplicationUnitTest
{
    [TestClass]
    public class CustomerTest
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerTest()
        {
            _customerRepository = new MockedCustomerRepository();
        }



        [TestMethod]
        public async Task GetAllCustomers_ShouldReturnAllCustomers()
        {
            //Arrange 
            int countRealList = 4;

            // Act
            List<ICustomer> customers = await _customerRepository.GetAllCustomers();

            // Assert
            Assert.IsNotNull(customers);
            Assert.AreEqual(countRealList, customers.Count); // Assuming there are 4 customers in the mock repository
        }


        [TestMethod]
        public async Task GetCustomerByUsername_ShouldReturnCorrectCustomer()
        {
            // Arrange
            string usernameToFind = "user1"; // Assuming this username exists in the mock repository

            // Act
            ICustomer customer = _customerRepository.GetCustomer(usernameToFind);

            // Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(usernameToFind, customer.Username);
        }

        [TestMethod]
        public async Task GetCustomerByID_ShouldReturnCorrectCustomer()
        {
            //Arrange
            int customerIdToFind = 2;

            //Act
            var customer = _customerRepository.GetCustomerByID(customerIdToFind);

            //Assert
            Assert.IsNotNull(customer);
            Assert.AreEqual(customerIdToFind, customer.CustomerId);
        }

        [TestMethod]
        public async Task CreateCustomer_ShouldCreateNewCustomer()
        {
            //Arrange
            bool isCreated = await _customerRepository.CreateCustomer
                ("user5", "user5", "user", "John", "Doe", "5555555", "john@example.com", "Address");

            //Act
            Assert.IsTrue(isCreated);
            var newCustomer = _customerRepository.GetCustomer("user5");

            //Assert
            Assert.IsNotNull(newCustomer);
            Assert.AreEqual("John", newCustomer.Firstname);
        }




        [TestMethod]
        public async Task UpdateCustomer_ShouldUpdateCustomer()
        {
            //Arrange
            int customerIdToUpdate = 3;
            bool isUpdated = await _customerRepository.UpdateCustomer(customerIdToUpdate,
                "user3", "newpass", "Updated", "Customer", "9999999", "updated@example.com", "Updated Address");
            
            //Act
            Assert.IsTrue(isUpdated);
            var updatedCustomer = _customerRepository.GetCustomerByID(customerIdToUpdate);

            //Assert
            Assert.IsNotNull(updatedCustomer);
            Assert.AreEqual("newpass", updatedCustomer.Password);
        }



        [TestMethod]
        public async Task DeleteCustomer_ShouldDeleteCustomer()
        {
            //Arrange
            int customerIdToDelete = 4;
            bool isDeleted = await _customerRepository.DeleteCustomer(customerIdToDelete);
            Assert.IsTrue(isDeleted);

            //Act
            var deletedCustomer = _customerRepository.GetCustomerByID(customerIdToDelete);

            //Assert
            Assert.IsNull(deletedCustomer);
        }
    }
}
