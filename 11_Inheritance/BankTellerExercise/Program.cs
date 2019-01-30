using System;
using BankTellerExercise.Classes;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the Bank Account Application");

            BankCustomer PopPop = new BankCustomer(); 

            ///instantiate newAccount1
            BankAccount donorAccount = new BankAccount();
            ///intantiate newAccount2
            BankAccount receiverAccount = new BankAccount();
            ///add money to both accounts using deposit method
            donorAccount.Deposit(100M);
            receiverAccount.Deposit(100M);

            CheckingAccount checkingAccount_GeorgeMichael = new CheckingAccount();


            ///write out amount $$$ in each
            Console.WriteLine($"Balance of donorAccount: ${donorAccount.Balance:C2} | Balance of Receiver Account: ${receiverAccount.Balance}");

            ///transfer $$$ from new Account 1 to new Account 2
            donorAccount.Transfer(receiverAccount, 50M);

            //////write out amount $$$ in each after transfer
            Console.WriteLine($"Balance of donorAccount: {donorAccount.Balance:C2} | ${receiverAccount.Balance}");

            // test out withdraw and overdraft scenarios
            decimal overDrawMoneyTest = checkingAccount_GeorgeMichael.Withdraw(90M);
            //get new balance and print out
            Console.WriteLine($"This the account balance: {checkingAccount_GeorgeMichael.Balance:C2}");


            //Create new savings account
            SavingsAccount savingAccountForPopPop = new SavingsAccount();
            //Add $149 to the savings account
            savingAccountForPopPop.Deposit(-190);
            //Print new balance
            Console.WriteLine($"Balance for savings account: {savingAccountForPopPop.Balance:C2}");
            //Test withdraw for savings account
            savingAccountForPopPop.Withdraw(90);
            Console.WriteLine($"Balance for savings account after withdrawing $490: {savingAccountForPopPop.Balance:C2}");
            PopPop.AddAccount(checkingAccount_GeorgeMichael);
            PopPop.AddAccount(savingAccountForPopPop);
            Console.WriteLine($"PopPop  currently has {PopPop.Accounts.Length } accounts.");

            //Deposit into PopPop's checking account
            checkingAccount_GeorgeMichael.Deposit(10000000);
            Console.WriteLine($"${checkingAccount_GeorgeMichael.Deposit(100)} deposited into George Michael's checking account.");

            //WithDraw money from PopPop's checking account
            decimal withDrawAmount =
            checkingAccount_GeorgeMichael.Withdraw(75);
            Console.WriteLine($"$ 75 withdrawn. Currently ${withDrawAmount} in George Michael's checking account");
            Console.WriteLine($"Is PopPop a VIP? {PopPop.IsVIP }");
        }
    }
}
