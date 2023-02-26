using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    internal class Employee_Attendance
    {
        public static void EmployeeAttendancecheck()
        {
            int is_full_time = 1;

            Random rnd = new Random();
            int emp_check = rnd.Next(0, 2);
            if (is_full_time == emp_check)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Abscent");
            }
        }
    }
}
