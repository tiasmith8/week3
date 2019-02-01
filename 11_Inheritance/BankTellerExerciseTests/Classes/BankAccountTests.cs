using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void TestNegativeDepositAmount()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();

            //Act - deposit negative amount
            decimal returnedBalance = bankAccount.Deposit(-100);

            //Assert - balance should remain the same
            Assert.AreEqual(0, (double)returnedBalance, "Balance should be unchanged.");

        }

    }
}
