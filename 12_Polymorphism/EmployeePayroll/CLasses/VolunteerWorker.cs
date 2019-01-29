using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePayroll.CLasses
{
    public class VolunteerWorker : IWorker
    {
        /// <summary>
        /// Volunteer Worker's first name.
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        /// Volunteer Worker's last name.
        /// </summary>
        public string LastName { get; }

        public double CalculateWeeklyPay(int hoursWorked)
        {
            return hoursWorked * 0;
        }

        /// <summary>
        /// Creates a new VolunteerWorker
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public VolunteerWorker(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }


    }
}
