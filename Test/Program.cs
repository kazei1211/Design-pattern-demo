using System;
using System.Collections.Generic;

// Component Interface
public interface Employee
{
    decimal GetSalary();
    void DisplayDetails();
}

// Composite Class
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

// Leaf Class
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

// Client Code
public class CompanyStructure
{
    public static void Main(string[] args)
    {
        // CEO
        Manager ceo = new Manager("John", "CEO", 10000);

        // Vice Directors
        Manager marketingDirector = new Manager("Alice", "VDr Marketing", 7000);
        Manager productionDirector = new Manager("Bob", "VDr SanXuat", 7000);

        // Staff under Marketing Director
        Staff advertisingStaff1 = new Staff("Charlie", "NV QuangCao", 3000);
        Staff advertisingStaff2 = new Staff("David", "NV QuangCao", 3000);

        // Staff under Production Director
        Staff accountingStaff1 = new Staff("Eve", "NV KeToan", 3000);
        Staff accountingStaff2 = new Staff("Frank", "NV KeToan", 3000);
        Staff logisticsStaff = new Staff("Grace", "NV VanChuyen", 3000);

        // Build hierarchy
        ceo.AddEmployee(marketingDirector);
        ceo.AddEmployee(productionDirector);

        marketingDirector.AddEmployee(advertisingStaff1);
        marketingDirector.AddEmployee(advertisingStaff2);

        productionDirector.AddEmployee(accountingStaff1);
        productionDirector.AddEmployee(accountingStaff2);
        productionDirector.AddEmployee(logisticsStaff);

        // Display the structure and salaries
        ceo.DisplayDetails();

        // Example usage of GetChildren
        Console.WriteLine("\nChildren of the CEO:");
        foreach (var child in ceo.GetChildren())
        {
            child.DisplayDetails();
        }
    }
}
