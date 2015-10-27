using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass3
{
    abstract class Employee : IEmployee
    {
        //Private variables
        private string firstName;
        private string lastName;
        private string department;

        //Propertiest for variables
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        /*public string FirstName
        {
            get { return department; }
            set { department = value; }
        }*/

        //3 Parameter Constructor
        public Employee(string FirstName, string LastName, string Department)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.department = Department;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

        protected virtual void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }

        public abstract decimal CalculateWeeklyGross();


        //public abstract string GetDepartmentTwice();

        public virtual string GetDepartmentTwice()
        {
            return this.department + this.department;

        }

        public int CompareTo(object obj)
        {
            Employee otherEmployee = (Employee)obj;
            //return this.CalculateWeeklyGross().CompareTo(otherEmployee.CalculateWeeklyGross());

            decimal thisWeeklyGross = this.CalculateWeeklyGross();

            decimal otherGuysWeeklyGross = otherEmployee.CalculateWeeklyGross();

            return thisWeeklyGross.CompareTo(otherGuysWeeklyGross);
        }
    }
}
