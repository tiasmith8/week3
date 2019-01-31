using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests
{
    [TestClass]
    public class CheckingAccountTests
    {


        [TestMethod]
        public void CheckingAccountTest_ForDepositingNegativeMoney()
        {
            //Arrange: $0 balance start
            CheckingAccount checkingAccount = new CheckingAccount();

            //Act(call method we want to test)
            decimal deposit = checkingAccount.Deposit(-100);

            //Assert
            Assert.AreEqual(0, deposit, "Cannot deposit negative money.");

        }

        [TestMethod]
        public void CheckingAccount_Withdrawing_NegativeMoneyTest()
        {
            //Arrange
            CheckingAccount checkingAccount = new CheckingAccount();

            //Act
            decimal balance = checkingAccount.Withdraw(-100);

            //Assert
            Assert.AreEqual(0, balance, "Cannot withdraw negative money.");

        }

        [TestMethod]
        public void CheckingAccount_Transfer_Test()
        {
            //Arrange
            CheckingAccount checkingAccountTransferFrom = new CheckingAccount();
            CheckingAccount accountTransferTo = new CheckingAccount();

            //Act
            checkingAccountTransferFrom.Transfer(accountTransferTo, 100);

            //Assert
            Assert.AreEqual(checkingAccountTransferFrom.Balance, -100, "Decrement balance from 0 to -100");
            Assert.AreEqual(accountTransferTo.Balance, 100, "Received $100 transfer.");

        }
    }
}
