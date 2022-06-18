using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CheckAttendance
    {
        public void CalculateEmployeeWage()
        {

            int FullDayHr = 8;
            int WagePerHr = 20;
            int totalWage = 0;
            int PartTimeHr = 4;
            Random random = new Random();
            int number = random.Next(0, 3);
            switch (number)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is present");
                    totalWage = FullDayHr * WagePerHr;
                    break;
                case 2:
                    Console.WriteLine("Employee is present and part time employee");
                    totalWage = PartTimeHr * WagePerHr;
                    break;

            }
            Console.WriteLine("Employee's total wage  is " + totalWage);



        }
    }
}
