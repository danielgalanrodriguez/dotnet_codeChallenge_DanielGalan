using NUnit.Framework;
using dotnet_codeChallenge_DanielGalan.Models;

namespace dotnet_codeChallenge_DanielGalan.Tests
{
    public class UsersTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void userRegister_registerOK_returns1()
        {  // Arrange
            var user = new Users();
            user.email = "test@test.test";

            //Act
            var result = user.registerUser();
            
            //Assert
            Assert.That( result=="1");
        }

        [Test]
        public void updateUser_updateOK_returns1()
        {  // Arrange
            var user = new Users();
            user.id = 1;
            user.email="putTest@test.test";

            //Act
            var result = user.updateUser();
            
            //Assert
            Assert.That( result=="1");
        }
    }
}