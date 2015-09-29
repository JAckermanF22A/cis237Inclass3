using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee salaryEmployee = new SalaryEmployee("Trash", "Boat", "Park Employee", 5);

            Console.WriteLine(salaryEmployee.ToString());

            Console.WriteLine(salaryEmployee.CalculateWeeklyGross());

            Console.WriteLine("*********************************************************************");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Peter", "Parker", "Avenger", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine((hourlyEmployee.CalcWeeklyGross(hourlyEmployee.HoursWorked)).ToString("C"));

        }
    }
}
