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
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }


        //Create
        public async Task<bool> CreateAdmin(string username, string password, string usertype,
            string firstname, string lastname, string phonenumber, string email, string address, string salary)
        {
            return await _adminRepository.CreateAdmin(username, password, usertype,
                firstname, lastname, phonenumber, email, address, salary);
        }


        //Delete
        public async Task<bool> DeleteAdmin(int adminid)
        {
            return await _adminRepository.DeleteAdmin(adminid);
        }


        //Read One By ID
        public IAdmin GetAdminByID(int adminID)
        {
            return _adminRepository.GetAdminByID(adminID);
        }


        //Read One By UserName
        public IAdmin GetAdminByUserName(string username)
        {
            return _adminRepository.GetAdminByUserName(username);
        }


        //Read All
        public async Task<List<IAdmin>> GetAllAdmins()
        {
            return await _adminRepository.GetAllAdmins();
        }


        //Update
        public async Task<bool> UpdateAdmin(int adminID, string username, string password, string firstname, 
            string lastname, string phonenumber, string email, string address, string salary)
        {
            return await _adminRepository.UpdateAdmin(adminID, username, password,
                firstname, lastname, phonenumber, email, address, salary);
        }
    }
}
