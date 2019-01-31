using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        /// <summary>
        /// /Returns the account holder name that the account belongs to.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Returns the account holder name that the account belongs to.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Returns the account number that the account belongs to.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Returns the customer's list of BankAccounts as an array.
        /// </summary>
        public BankAccount[] Accounts
        {
            get
            {
                return completeListofBankAccounts.ToArray(); 
            }
        }
       List<BankAccount> completeListofBankAccounts= new List<BankAccount>(); 

        /// <summary>
        /// Adds newAccount to the customer's list of accounts.
        ///Sample usage
        /// </summary>
        /// <param name="newAccount"></param>

        public void AddAccount(BankAccount newAccount)
        {
            this.completeListofBankAccounts .Add(newAccount); 
        }

        public bool IsVIP { get
            {
                ///if checking + savings => $25k, then return true, else
                ///false. 
                ///
                decimal sumAccts = 0;
                foreach (BankAccount Acct in completeListofBankAccounts)
                {
                    sumAccts = sumAccts + Acct.Balance;
                    
                }

                return (sumAccts >= 25000);
                    

                    
            } }




    }
}
