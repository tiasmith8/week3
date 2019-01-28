using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        /// <summary>
        /// returns account number that the account belongs to
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// returns the Balance value of the Bank account in USD
        /// </summary>
        public decimal Balance { get; private set; }
        /// <summary>
        /// Adds amount to deposit to the current balance, and 
        /// returns the new balance of the bank account
        /// </summary>
        /// <param name="amountToDeposit"></param>
        /// <returns></returns>
        public decimal Deposit(decimal amountToDeposit)
        {
            this.Balance = this.Balance + amountToDeposit;
            return this.Balance;
        }
        /// <summary>
        /// Subtracts amount to withdraw from the current
        /// balance, and returns the new balance of the
        /// bank account
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            this.Balance = this.Balance - amountToWithdraw;
            return this.Balance; 
        }
        /// <summary>
        /// Withdraws transferAmount from the Account and deposits
        /// it into destinationAccount
        /// </summary>
        /// <param name="destinationAccount"></param>
        /// <param name="transferAmount"></param>
        public void Transfer(BankAccount  destinationAccount, decimal transferAmount)
        {
            this.Balance = this.Balance - transferAmount;
            destinationAccount.Balance += transferAmount; 
        }
        ///A new bank account's balance is defaulted to
        ///a zero balance
        public BankAccount()
        {
            this.Balance = 0; 
        }
    }
}
