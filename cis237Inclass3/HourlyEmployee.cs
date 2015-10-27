using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    class HourlyEmployee : Employee
    {
        private decimal hourlyRate;
        private double hoursWorked;

        
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }

        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        //4 Parameter constructor that calls the base constructor with 3 of the parameters, and then assigns the last one to the hourly rate.
        public HourlyEmployee(string FirstName, string LastName, string Department, decimal HourlyRate) : base(FirstName, LastName, Department)
        {
            this.hourlyRate = HourlyRate;   
        }

        public override string ToString()
        {
            return base.ToString() + " " + hourlyRate.ToString("C");
        }

        //Note: Did not override teh PrintFUllName protected virtual method even though it is protected and virtual, we aren't going to override it.
        //Calling it will just call teh parent version

        public override decimal CalculateWeeklyGross()
        {
            return hourlyRate * (decimal)hoursWorked;
        }

        public override string GetDepartmentTwice()
        {
            return base.GetDepartmentTwice() + base.GetDepartmentTwice();
        }
    }
}
