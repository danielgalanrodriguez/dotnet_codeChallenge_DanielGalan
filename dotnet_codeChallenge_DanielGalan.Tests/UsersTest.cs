using NUnit.Framework;
using dotnet_codeChallenge_DanielGalan.Models;

namespace dotnet_codeChallenge_DanielGalan.Tests
{
    public class UsersTest
    {
        Users user;

        public UsersTest()
        {
        user = new Users();
        }


        [Test]
        public void userRegister_registerOK_returns1()
        {  // Arrange
            user.email = "test@test.test";
            user.name = "testName";
            user.surname = "testSurname";
            user.password = "testPassword";

            //Act
            var result = user.registerUser();
            
            //Assert
            Assert.That( result=="1");
        }

        [Test]
        public void updateUser_updateOK_returns1()
        {  // Arrange
            user.email="putTest@test.test";
            user.name = "putName";
            user.surname = "putSurname";
            user.password = "putPassword";
            user.id=1;

            //Act
            var result = user.updateUser();
            
            //Assert
            Assert.That( result=="1");
        }
 
        [Test]
        public void deleteUser_deleteOK_returns1()
        {  // Arrange
            var user = new Users();
            user.email="delete@test.test";
            user.name = "deleteName";
            user.surname = "deleteSurname";
            user.password = "deletePassword";
            user.registerUser();
            user.id=user.getLastUserId();
            //Act
            var result = user.deleteUser(user.id);
            
            //Assert
            Assert.That( result=="1");
        }
    }
}