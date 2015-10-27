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

            Console.WriteLine(salaryEmployee.GetDepartmentTwice());

            Console.WriteLine("*********************************************************************");

            HourlyEmployee hourlyEmployee = new HourlyEmployee("Peter", "Parker", "Avenger", 8.37m);
            hourlyEmployee.HoursWorked = 40;

            Console.WriteLine(hourlyEmployee.ToString());
            Console.WriteLine((hourlyEmployee.CalculateWeeklyGross()).ToString("C"));
            Console.WriteLine(hourlyEmployee.GetDepartmentTwice());

            Console.WriteLine("**********************************************************************");

            HourlyEmployee joe = new HourlyEmployee("Joeseph", "Joestar", "Stand User", 250m);
            joe.HoursWorked = 87;

            SalaryEmployee dave = new SalaryEmployee("Dave", "Barnes", "IT", 150000m);

            Employee spiff = new SalaryEmployee("Spiff", "Lightspace", "Professional Space Guy", 0m);

            IEmployee newPerson = new HourlyEmployee("Silent", "Hill", "City", 100000.00m);

            HourlyEmployee myStack;
            myStack = (HourlyEmployee)newPerson;

            //Create an array of type IEmployee, and pass in the two instances we created.
            //IEmployee can contain instances that are lower on the inheritance chain.
            //(More specific implementations)
            IEmployee[] employeeList = { joe, dave, new SalaryEmployee("Jack", "Ramen", "Pit Lord", 750000m), spiff };

            //Now we can loop through the list of employees and call teh CalculateWeeklyGross
            //On each of the employees. The porgram will be smart enough to know which method to call depending on the current instance it is working with.
            foreach(IEmployee employee in employeeList)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine(employee.CalculateWeeklyGross());
                Console.WriteLine();
            }
            
            
        }
    }
}
