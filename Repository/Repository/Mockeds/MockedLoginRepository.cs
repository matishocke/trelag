using Abstraction.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository.Mockeds
{
    public class MockedLoginRepository : ILoginRepository
    {
        public async Task<bool> Login(string username, string password, string userType)
        {
            if (username == "user" && password == "user" && userType == "user")
            {
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(false);
            }
        }
    }
}
