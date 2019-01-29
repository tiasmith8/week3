using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class HourlyWorker : IWorker
    {
        //Properties
        public double HourlyRate { get; }

        /// <summary>
        /// Hourly Worker's first name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Hourly Worker's last name.
        /// </summary>
        public string LastName { get; }

        /// <summary>
        /// Calculate Hourly Worker's weekly pay.
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public double CalculateWeeklyPay(int hoursWorked)
        {
            /*      Josh gave us this on Ryver
                    pay = hourly rate * hoursWorked
                    overtime = hoursWorked - 40
                    pay = pay + (hourly rate * overtime * .5)
             */

            double pay =  this.HourlyRate * hoursWorked;
            double overtime = hoursWorked - 40;
            pay = pay + (this.HourlyRate * overtime * 0.5);

            return pay;
        }

        //Constructor
        /// <summary>
        /// Create a new Hourly Worker.
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            this.HourlyRate = hourlyRate;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
