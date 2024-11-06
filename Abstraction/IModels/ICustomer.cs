using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IModels
{
    public interface ICustomer
    {
        
        int CustomerId { get; set; }
        string Firstname { get; set; }
        string Lastname { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string PhoneNumber { get; set; }
        string UserType { get; set; }
    }
}
