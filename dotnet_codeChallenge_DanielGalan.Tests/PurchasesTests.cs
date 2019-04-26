using NUnit.Framework;
using dotnet_codeChallenge_DanielGalan.Models;

namespace dotnet_codeChallenge_DanielGalan.Tests
{
    public class PurchasesTests
    {
        Purchases purchase;

        public PurchasesTests()
        {
        purchase = new Purchases();
        }


        [Test]
        public void registerPurchase_registerOK_returns1()
        {  // Arrange
            purchase.user_id=1;
            purchase.book_id=5;

            //Act
            var result = purchase.registerPurchase();
            
            //Assert
            Assert.That( result=="1");
        }

 
    }
}