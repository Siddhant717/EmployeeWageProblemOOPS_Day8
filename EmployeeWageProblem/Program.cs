﻿using System;

namespace EmployeeWageProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");

            CheckAttendance calculatewage = new CheckAttendance();
            calculatewage.CalculateWage();
        }
    }
}
