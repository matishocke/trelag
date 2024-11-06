using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IService
{
    public interface ICustomerService
    {
        Task<List<ICustomer>> GetAllCustomers();

        ICustomer GetCustomer(string username);
        ICustomer GetCustomerByID(int customerID);
        Task<bool> CreateCustomer(string username, string password, string usertype, string firstname, 
            string lastname, string phonenumber, string email, string address);

        Task<bool> UpdateCustomer(int customerID, string username, string password, string firstname, string lastname, 
            string phonenumber, string email, string address);

        Task<bool> DeleteCustomer(int customerid);

       
    }
}
