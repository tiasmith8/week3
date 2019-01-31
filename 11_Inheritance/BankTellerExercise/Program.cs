using System;
using BankTellerExercise.Classes;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the Bank Account Application");

            CheckingAccount checkingAccountTest = new CheckingAccount();
            CheckingAccount checkingAccountTestDestination = new CheckingAccount();
            checkingAccountTest.Transfer(checkingAccountTestDestination, 10);
            
            ///instantiate newAccount1
            BankAccount donorAccount = new BankAccount();
            
            ///intantiate newAccount2
            BankAccount receiverAccount = new BankAccount();
            
            ///add money to both accounts using deposit method
            donorAccount.Deposit(100M);
            receiverAccount.Deposit(100M);

            CheckingAccount checkingAccountOfSusie = new CheckingAccount();

            ///write out amount $$$ in each
            Console.WriteLine($"Balance of donorAccount: ${donorAccount.Balance:C2} | Balance of Receiver Account: ${receiverAccount.Balance}");

            ///transfer $$$ from new Account 1 to new Account 2
            donorAccount.Transfer(receiverAccount, 50M);

            //////write out amount $$$ in each after transfer
            Console.WriteLine($"Balance of donorAccount: {donorAccount.Balance:C2} | ${receiverAccount.Balance}");

            // test out withdraw and overdraft scenarios
            decimal overDrawMoneyTest = checkingAccountOfSusie.Withdraw(90M);
            
            //get new balance and print out
            Console.WriteLine($"This the account balance: {checkingAccountOfSusie.Balance:C2}");

            //Create new savings account
            SavingsAccount brandNewSavingAccountForSomeone = new SavingsAccount();
            
            //Add $149 to the savings account
            brandNewSavingAccountForSomeone.Deposit(-190);
            
            //Print new balance
            Console.WriteLine($"Balance for savings account: {brandNewSavingAccountForSomeone.Balance:C2}");
            
            //Test withdraw for savings account
            brandNewSavingAccountForSomeone.Withdraw(90);
            Console.WriteLine($"Balance for savings account after withdrawing $490: {brandNewSavingAccountForSomeone.Balance:C2}");

        }
    }
}
