using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmenOOP02
{

    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Gender Gender { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate { get; set; }

        public Employee(int id, string name, Gender gender, SecurityLevel securityLevel, decimal salary, HiringDate hireDate)
        {
            Id = id;
            Name = name;
            Gender = gender;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Gender: {Gender}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate}";
        }
    }
}


