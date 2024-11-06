using Abstraction.IRepository;
using Abstraction.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class LoginService : ILoginService
    {
        private readonly ILoginRepository _loginRepository;
        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }
        public async Task<bool> Login(string username, string password, string userType)
        {
            return await _loginRepository.Login(username, password, userType);
        }
    }
}
