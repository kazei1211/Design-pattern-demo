using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Staff : Employee
    {
        private string name;
        private string position;
        private decimal salary;

        public Staff(string name, string position, decimal salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public decimal GetSalary()
        {
            return salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{position}: {name}, Salary: {salary}");
        }
    }
}
