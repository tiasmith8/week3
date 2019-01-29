using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public interface IWorker
    {
        //Properties
        /// <summary>
        /// First name of the worker.
        /// </summary>
        string FirstName { get; }

        /// <summary>
        /// Last name of the worker.
        /// </summary>
        string LastName { get; }

        //Methods
        /// <summary>
        /// Calculate the weekely pay.
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        double CalculateWeeklyPay(int hoursWorked);

    }
}
