using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    internal class Employee_Attendance
    { //UC2_Calculate Daily Employee Wage 
        public const int WAGE_PER_HOUR = 20;
        public static int EmployeeAttendancecheck()
        {
           const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int emp_hour = 0;

            Random rnd = new Random();
            int emp_attendance_check = rnd.Next(0,3);
            if (emp_attendance_check == IS_FULL_TIME)
            {
                emp_hour = 8;
            }
            else if (emp_attendance_check == IS_PART_TIME)
            {
                emp_hour = 4;
            }
            else 
            {
                emp_hour = 0;
            }
            int dailywage = emp_hour * WAGE_PER_HOUR;
            return dailywage;
        }
    }
}
