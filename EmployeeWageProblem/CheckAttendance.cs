using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CheckAttendance
    {
        public void EmployeeWage()
        {

           int FullDayHr = 8;
            int WagePerHr = 20;
            int totalWage = 0;
            int PartTimeHr = 4;
            Random random = new Random();
            int number = random.Next(0, 3);
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");


            }
            else if (number == 1)
            {
                Console.WriteLine("Employee is present");
                totalWage = FullDayHr * WagePerHr;

            }
            else
            {
                Console.WriteLine("Employee is present and part time employee");
                totalWage = PartTimeHr * WagePerHr;

            }
            Console.WriteLine("Employee's total wage  is " + totalWage);
        }
    }
}
