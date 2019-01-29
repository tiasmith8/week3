using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class SalaryWorker : IWorker
    {
        //Properties***************
        /// <summary>
        /// Represents the annual salary
        /// </summary>
        public double AnnualSalary{ get; }

        /// <summary>
        /// Salary Worker's first name.
        /// </summary>
        public string FirstName{ get; }

        /// <summary>
        /// Salary Worker's last name.
        /// </summary>
        public string LastName{ get; }


        //Methods***************
        /// <summary>
        /// Returns SalaryWorker's weekly pay.
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public double CalculateWeeklyPay(int hoursWorked)
        {
            //Weekly pay: pay = annual salary / 52
            return this.AnnualSalary / 52;
        }

        //Constructor***************
        /// <summary>
        /// Creates a new SalaryWorker.
        /// </summary>
        /// <param name="annualSalary"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            this.AnnualSalary = annualSalary;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
