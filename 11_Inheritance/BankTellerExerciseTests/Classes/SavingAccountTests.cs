using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingAccountTests
    {
        [TestMethod]
        public void SavingsAccount_Withdraw_NegativeMoney()
        {
            //Arrange
            SavingsAccount savingsAccount = new SavingsAccount();

            //Act - test the withdraw method
            decimal balance = savingsAccount.Withdraw(-100);

            //Assert
            Assert.AreEqual(0, balance, "Cannot withdraw negative money.");

        }

        [TestMethod]
        public void SavingsAcount_Withdraw_LessThan_150Dollars()
        {
            //If the balance is less than $150 charge $2
            //Arrange
            SavingsAccount savingsAccount = new SavingsAccount();
            decimal initialDepositAmount = savingsAccount.Deposit(149);

            //Act - test the withdraw method
            decimal balance = savingsAccount.Withdraw(75);

            //Assert
            Assert.AreEqual(72, balance, "Testing that positive withdraw charges $2 with less than $150");
        }

        [TestMethod]
        public void SavingsAccount_Withdraw_MoreThan_150Dollars()
        {
            //If the balance is more than $150 don't charge $2
            //Arrange
            SavingsAccount savingsAccount = new SavingsAccount();
            decimal initialDepositAmount = savingsAccount.Deposit(151);

            //Act - test the withdraw method
            decimal balance = savingsAccount.Withdraw(75);

            //Assert
            Assert.AreEqual(76, balance, "Testing that positive withdraw doesn't charge $2 with more than $150");

        }
    }
}
