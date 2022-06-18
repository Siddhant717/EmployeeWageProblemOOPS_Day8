using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CheckAttendance
    {
        public void CalculateDailyEmpWage()
        {

            int FullDayHr = 8;
            int WagePerHr = 20;
            int totalWage = 0;

            Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Employee's total wage  is " + totalWage);

            }
            else
            {
                Console.WriteLine("Employee is present");
                totalWage = FullDayHr * WagePerHr;
                Console.WriteLine("Employee's total wage  is " + totalWage);
            }
        }
    }
}
