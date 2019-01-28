using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{  //A checkingAccount is subclass of the class BankAccount
   // Bankaccount is also the superclass to checkingAccount

    public class CheckingAccount : BankAccount
    {

        //set up class properties and methods
        ///extending functionality special to a checking account.
        ///but in this case, in order to do this, we are actually
        ///overriding the withdraw method in BankAccount
        ///
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            //if .Balance<0, withdraw $10 overdraft fee 
            //from the account


            //if checking Balance == -100, it fails and balance
            //remains same. Balance comes from the superclass 

            if ((Balance - amountToWithdraw) < (decimal)-90)
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

