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
<<<<<<< HEAD

        /// <summary>
        /// Withdraw money from bank account.
=======
        /// <summary>
        /// Return balance from checking withdrawl
>>>>>>> 9ad4c8fa2b70af3e294494544b1ab98f86c30aee
        /// </summary>
        /// <param name="amountToWithdraw"></param>
        /// <returns></returns>
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //if .Balance<0, withdraw $10 overdraft fee 
            //from the account
            //if checking Balance == -100, it fails and balance
            //remains same. Balance comes from the superclass 
<<<<<<< HEAD
            if (amountToWithdraw < 0 || (Balance - amountToWithdraw) < (decimal)-90)
=======
            
            if ((Balance - amountToWithdraw) < (decimal)-90)
>>>>>>> 9ad4c8fa2b70af3e294494544b1ab98f86c30aee
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

