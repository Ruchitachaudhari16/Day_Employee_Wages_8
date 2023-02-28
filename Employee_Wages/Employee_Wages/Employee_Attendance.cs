using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    internal class Employee_Attendance

    { // calcu;lating wages per month
         const int EMP_RATE_PER_HOUR = 20;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int NUM_OF_WORKING_DAYS = 20;
        private static int total_emp_wage;

        public static int EmployeeDailyWage()
        {
            int emp_hour;
            Random rnd = new Random();
            int emp_attendance_check = rnd.Next(0, 3);
           

            switch (emp_attendance_check)
            {
                case IS_PART_TIME:
                    emp_hour = 4;
                    break;
                case IS_FULL_TIME:
                    emp_hour = 8;
                    break;
                default:
                    emp_hour = 0;
                    break;
            }
                    int emp_wage = emp_hour * EMP_RATE_PER_HOUR;
                    return total_emp_wage=+emp_wage;
            }
        }
    }

