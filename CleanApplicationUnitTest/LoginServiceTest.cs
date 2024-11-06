using Abstraction.IRepository;
using Abstraction.IService;
using Repository.Repository;
using Repository.Repository.Mockeds;

namespace CleanApplicationUnitTest
{
    [TestClass]
    public class LoginServiceTest
    {
        private readonly ILoginRepository _loginRepository;
        public LoginServiceTest()
        {
            _loginRepository = new MockedLoginRepository();
        }



        [TestMethod]
        public async Task TestLoginSuccessfulScenario()
        {
            

            //Arrange
            string validUserName = "user";
            string validPassword = "user";
            string validUserType = "user";

            //Act
            bool loginResult = await _loginRepository.Login(validUserName, validPassword, validUserType);

            //Assert 
            Assert.IsTrue(loginResult, "Login should succeed for valid credentials.");
        }


        [TestMethod]
        public async Task TestLoginFailedScenario()
        {
            
            //Arrange
            string invalidUserName = "notuser";
            string invalidPassword = "notuser";
            string invalidUserType = "notuser";


            //Act
            bool loginResult = await _loginRepository.Login(invalidUserName, invalidPassword, invalidUserType);


            //Assert 
            Assert.IsFalse(loginResult, "Login should fail for invalid credentials.");
        }
    }
}