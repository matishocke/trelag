using Abstraction.IModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.IService
{
    public interface IAdminService
    {
        Task<List<IAdmin>> GetAllAdmins();

        IAdmin GetAdminByUserName(string username);
        IAdmin GetAdminByID(int adminID);

        Task<bool> CreateAdmin(string username, string password, string usertype, string firstname,
            string lastname, string phonenumber, string email, string address, string salary);


        Task<bool> UpdateAdmin(int adminID, string username, string password, string firstname, string lastname,
            string phonenumber, string email, string address, string salary);


        Task<bool> DeleteAdmin(int adminid);
    }
}
