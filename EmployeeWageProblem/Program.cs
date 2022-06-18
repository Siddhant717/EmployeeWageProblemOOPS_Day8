using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            CheckAttendance empwage = new CheckAttendance();
            empwage.CalculateDailyEmpWage();
        }
    }
}
