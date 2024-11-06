using Abstraction.IModels;
using Abstraction.IRepository;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository repository)
        {
            _customerRepository = repository;
        }

        //READ ALL
        public Task<List<ICustomer>> GetAllCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }


        //READ one
        public ICustomer GetCustomer(string username)
        {
            return _customerRepository.GetCustomer(username);
        }
        public ICustomer GetCustomerByID(int customerID)
        {
           return _customerRepository.GetCustomerByID(customerID);
        }



        //CREATE
        public async Task<bool> CreateCustomer(string username, string password, string usertype,
            string firstname, string lastname, string phonenumber, string email, string address)
        {
            return await _customerRepository.CreateCustomer(username, password, usertype, firstname, 
                lastname, phonenumber, email, address);
        }


        //UPDATE
        public Task<bool> UpdateCustomer(int customerID, string username, string password, string firstname, string lastname,
           string phonenumber, string email, string address)
        {
            return _customerRepository.UpdateCustomer(customerID, username, password, firstname, lastname, phonenumber, email, address);
        }




        //DELETE
        public Task<bool> DeleteCustomer(int customerid)
        {
            return _customerRepository.DeleteCustomer(customerid);
        }

    }
}
