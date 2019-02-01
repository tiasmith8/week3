using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{   
    // A CheckingAccount is subclass of the BankAccount class
    // BankAccount is also the superclass to CheckingAccount
    public class CheckingAccount : BankAccount
    {
        //set up class properties and methods
        //extending functionality special to a checking account.
        //but in this case, in order to do this, we are actually
        //overriding the withdraw method in BankAccount

        /// <summary>
        /// Return balance from checking withdrawl
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //if .Balance<0, withdraw $10 overdraft fee 
            //from the account
            //if checking Balance == -100, it fails and balance
            //remains same. Balance comes from the superclass 
            
            if (amountToWithdraw < 0 || (Balance - amountToWithdraw) < (decimal)-90)
            {
                return Balance;
            }
            else if (Balance <= 0)
            {
                decimal newAccountBalance = base.Withdraw(amountToWithdraw + 10M);
                return newAccountBalance;
            }

            return base.Withdraw(amountToWithdraw);
        }
    }
}

