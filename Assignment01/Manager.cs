using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Manager : Employee
    {
        private string name;
        private string position;
        private decimal salary;
        private List<Employee> subordinates;

        public Manager(string name, string position, decimal salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.subordinates = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            subordinates.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            subordinates.Remove(employee);
        }

        public List<Employee> GetChildren()
        {
            return subordinates;
        }

        public decimal GetSalary()
        {
            return salary;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"{position}: {name}, Salary: {salary}");
            
            foreach (var subordinate in subordinates)
            {
                subordinate.DisplayDetails();
            }
        }
    }
}
