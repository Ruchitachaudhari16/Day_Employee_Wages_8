using System;
using System.Collections.Generic;
using System.Linq;
//using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    internal class Employee_Attendance

    { // calculating wages per month
       public  const int EMP_RATE_PER_HOUR = 20;
        public const int FULLDAYHRS = 1;
       public  const int PARTDAYHRS = 2;
       public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAXWORKINGHRSINMONTH = 100;
       

        public static int EmployeeAttendanceCheck()
        {

            Random rnd = new Random();
            int emp_attendance_check = rnd.Next(0,3);
            return emp_attendance_check;
        }
           public static int EmployeeDailyWage()
        {
            int check= EmployeeAttendanceCheck();
            int workingHrs = 0;

            switch (check)
            {
                case 0:
                    workingHrs = 0;
                    break;
                case 1:
                    workingHrs = 8;
                    break;
                case 2:
                    workingHrs = 4;
                    break;
                    
            }
                    int dailyWage = workingHrs * EMP_RATE_PER_HOUR;
                    return dailyWage;
            }
        public static int MonthlyWage()
        {
            int totalEmpWage = 0;
            for (int i = 1; i <= MAXWORKINGHRSINMONTH; i++)
            {
                totalEmpWage += EmployeeDailyWage();
            }
            return totalEmpWage;
        }
        public static int MonthlyWageBasedOnCriteria()
        {
            int totalEmpWage=0;
            int totalEmpHrs = 0;
            int totalDays = 0;
            while(totalEmpHrs < MAXWORKINGHRSINMONTH && totalDays< NUM_OF_WORKING_DAYS)
            {
                totalDays++;
                int dailyWage=EmployeeDailyWage();
                if (dailyWage == 160)
                    totalEmpHrs = 8;
                else if (dailyWage == 80)
                    totalEmpHrs = 4;
                totalEmpWage = dailyWage+totalEmpWage;
                Console.WriteLine(totalDays + " " + totalEmpHrs);
            }
            return totalEmpWage;
        }
        }
    }

