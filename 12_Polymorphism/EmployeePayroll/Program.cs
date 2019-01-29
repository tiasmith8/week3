using System;
using EmployeePayroll.CLasses;
using System.Collections.Generic;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create a list that represents a company's payroll
            List<IWorker> payroll = new List<IWorker>();

            //List holds a collection of the workers in it
            payroll.Add(new HourlyWorker(10.00, "Steve", "Holt"));
            payroll.Add(new VolunteerWorker("Bob", "Loblaw"));
            payroll.Add(new SalaryWorker(10_000, "Tobias", "Funke"));
            payroll.Add(new SalaryWorker(45_000, "Ann", "Veal"));

            int totalEmployeeHours = 0;
            double totalPayroll = 0;

            Console.WriteLine(@"Employee             Hours Worked           Pay");
            Console.WriteLine(@"====================================================");
            //Ouput each employee, the number of hours they're worked
            foreach (IWorker worker in payroll)
            {
                Random rnd = new Random();
                int hoursWorked = rnd.Next(1, 168);
                totalEmployeeHours += hoursWorked;
                totalPayroll = worker.CalculateWeeklyPay(hoursWorked);
                Console.WriteLine($"{worker.LastName}, {worker.FirstName}\t\t{hoursWorked}\t\t{totalPayroll:C2}");
            }

            Console.WriteLine();
            Console.WriteLine($"Total Hours: {totalEmployeeHours}");
            Console.WriteLine($"Total Pay: {totalPayroll:C2}");
            //Console.ReadLine();

            //use random number generator
            //also output the amount paid for the week

            //At the nd, show the sum of total hours worked and total 
            //weekly payroll


        }
    }
}
