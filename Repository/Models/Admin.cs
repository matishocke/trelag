using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Admin : IAdmin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public int AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Salary { get; set; }
    }
}
