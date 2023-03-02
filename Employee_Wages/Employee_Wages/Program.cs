using Employee_Wages;

namespace Employee_Wages
{
   
        internal class Program
        {
            static void Main(string[] args)
            {
            Employee dmart = new Employee("Dmart", 20, 2, 10);
            Employee reliance = new Employee("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.ToString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.ToString());
            }
        }
    }

