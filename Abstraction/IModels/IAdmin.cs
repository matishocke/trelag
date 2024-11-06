using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IModels
{
    public interface IAdmin
    {
        string UserName { get; set; }
        string Password { get; set; }
        string UserType { get; set; }
        int AdminID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Salary { get; set; }
    }
}
