using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    /// <summary>
    /// SavingsAccount IS-A BankAccount with some additional rules
    /// </summary>
    public class SavingsAccount : BankAccount
    {
        //Properties inherited from BankAccount

        //Methods
        /// <summary>
        /// If the balance is less than $150 charge $2
        /// If a withdraw is requested for > balance, withdraw fails and balance remains the same
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //If withdraw is requested for > balance
            if(amountToWithdraw > this.Balance)
            {
                return this.Balance;
            }
            // If the balance is less than $150 charge $2
            else if(this.Balance < 150M)
            {
                return base.Withdraw(amountToWithdraw + 2);
            }

            return base.Withdraw(amountToWithdraw);
        }

    }
}
