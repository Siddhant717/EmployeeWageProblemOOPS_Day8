using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class CheckAttendance
    {
        public void CheckEmployeeAttendance()
        {

          Random random = new Random();
            int number = random.Next(0, 2);
            if (number == 0)
            {
                Console.WriteLine("Employee is absent");

            }
            else
            {
                Console.WriteLine("Employee is present");

            }
        }
    }
}
