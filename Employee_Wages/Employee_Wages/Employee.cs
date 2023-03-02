using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
//using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages
{
    internal class Employee

    { //UC8 Ability to computeEmployee Wage for multiple companies
        public  const int PARTDAYHRS = 1;
        public const int FULLDAYHRS = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random= new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 0:
                        empHrs = 0;
                        break;
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + "Emp Hrs:" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company:" + company + "is :" + totalEmpWage);
            return totalEmpWage;
        

        }
        }
    }

