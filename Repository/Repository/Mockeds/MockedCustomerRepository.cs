using Abstraction.IModels;
using Abstraction.IRepository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Mockeds
{
    public class MockedCustomerRepository : ICustomerRepository
    {
        private readonly List<ICustomer> _customers;
        public MockedCustomerRepository()
        {
            _customers = new List<ICustomer>();
            _customers.Add(new Customer()
            {
                Username = "user1",
                Password = "user1",
                UserType = "user",
                CustomerId = 1,
                Firstname = "mati1",
                Lastname = "shokri1",
                PhoneNumber = "1111111",
                Email = "mati1@gmail.com",
                Address = "Tvedvej11"
            });

            _customers.Add(new Customer()
            {
                Username = "user2",
                Password = "user2",
                UserType = "user",
                CustomerId = 2,
                Firstname = "mati2",
                Lastname = "shokri2",
                PhoneNumber = "2222222",
                Email = "mati2@gmail.com",
                Address = "Tvedvej22"
            });
            _customers.Add(new Customer()
            {
                Username = "user3",
                Password = "user3",
                UserType = "user",
                CustomerId = 3,
                Firstname = "mati3",
                Lastname = "shokri3",
                PhoneNumber = "33333333",
                Email = "mati3@gmail.com",
                Address = "Tvedvej33"
            });
            _customers.Add(new Customer()
            {
                Username = "user4",
                Password = "user4",
                UserType = "user",
                CustomerId = 4,
                Firstname = "mati4",
                Lastname = "shokri4",
                PhoneNumber = "4444444",
                Email = "mati4@gmail.com",
                Address = "Tvedvej44"
            });
        }


        //Find All
        public Task<List<ICustomer>> GetAllCustomers()
        {
            return Task.FromResult(_customers);
        }


        //Find One By UserName
        public ICustomer GetCustomer(string username)
        {
            var foundCustomer = _customers.Find(x => x.Username == username);
            return foundCustomer;
        }


        //Find One By ID
        public ICustomer GetCustomerByID(int customerID)
        {
            var foundCustomerByID = _customers.Find(x => x.CustomerId == customerID);
            return foundCustomerByID;
        }


        //Create
        public Task<bool> CreateCustomer(string username, string password, string usertype, string firstname, string lastname, string phonenumber, string email, string address)
        {
            var newCustomer = new Customer()
            {
                Username = username,
                Password = password,
                UserType = usertype,
                Firstname = firstname,
                Lastname = lastname,
                PhoneNumber = phonenumber,
                Email = email,
                Address = address,
                CustomerId = _customers.Count + 1
            };
            _customers.Add(newCustomer);
            return Task.FromResult(true);
        }


        //Delete
        public Task<bool> DeleteCustomer(int customerid)
        {
            var customerToDelete = _customers.Find(x => x.CustomerId == customerid);
            if (customerToDelete != null)
            {
                _customers.Remove(customerToDelete);
                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }






        //Update
        public Task<bool> UpdateCustomer(int customerID, string username, string password, string firstname, string lastname, string phonenumber, string email, string address)
        {
            var existingCustomer = _customers.Find(c => c.CustomerId == customerID);
            if (existingCustomer != null)
            {
                existingCustomer.Username = username;
                existingCustomer.Password = password;
                existingCustomer.Firstname = firstname;
                existingCustomer.Lastname = lastname;
                existingCustomer.PhoneNumber = phonenumber;
                existingCustomer.Email = email;
                existingCustomer.Address = address;

                return Task.FromResult(true);
            }

            return Task.FromResult(false);
        }
    }
}
