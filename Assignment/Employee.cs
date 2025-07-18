using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment;
using System.Xml.Linq;

namespace Assignment
{
    public class Employee
    {
        public int ID; 
        public string Name;

        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender must be 'M' or 'F'");
            }
        }

        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public Employee (int id, string name, char gender, SecurityLevel security, decimal salary, HiringDate hireDate)
        {
            ID = id;
            Name = name;
            Gender = gender;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Security: {Security}, Salary: {string.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
        }
    }
}










