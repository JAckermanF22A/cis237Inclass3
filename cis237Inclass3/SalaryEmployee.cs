using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class SalaryEmployee : Employee
    {
        //Private variable for yearly salary
        private decimal yearlySalary;

        //Public property for yearly salary
        public decimal YearlySalary
        {
            get { return yearlySalary; }
            set { yearlySalary = value; }
        }
        //4 parameter constructor to create a new salary employee
        public SalaryEmployee(string FirstName, string LastName, string Department, decimal YearlySalary) : base(FirstName, LastName, Department)
        {
            this.yearlySalary = YearlySalary;
        }

        //OVerride the ToSTring method to include the salary
        public override string ToString()
        {
            
            return base.ToString() + " " + this.yearlySalary.ToString();
        }

        //Override of a method that WE wrote. Requires the method in the Employee class to be declared as virtual. It is also protected so that any cub classes
        //that inherit from this class can use it.
        protected override void PrintFullName()
        {
            Console.WriteLine(base.ToString() + " " + this.yearlySalary.ToString());
        }

        public override decimal CalculateWeeklyGross()
        {
            return this.yearlySalary / 52;
        }
    }
}
