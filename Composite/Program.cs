using Composite.Abstracts;
using Composite.Implementations;
using Composite.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Choose a Composite Pattern implementation:");
            Console.WriteLine("1. Using Interface");
            Console.WriteLine("2. Using Abstract Class");
            Console.WriteLine("3. Using Generics");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 3.\n");
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            switch (choice)
            {
                case 1:
                    RunInterfaceImplementation();
                    break;
                case 2:
                    RunAbstractClassImplementation();
                    break;
                case 3:
                    RunGenericsImplementation();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.\n");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void RunInterfaceImplementation()
    {
        Console.WriteLine("\n--- Composite Pattern Using Interface ---");
        IComponent root = new InterfaceComposite("Root");
        IComponent leaf1 = new InterfaceLeaf("Leaf1");
        IComponent leaf2 = new InterfaceLeaf("Leaf2");
        IComponent subComposite = new InterfaceComposite("SubComposite");
        IComponent leaf3 = new InterfaceLeaf("Leaf3");

        // Add children to root
        ((InterfaceComposite)root).Add(leaf1);
        ((InterfaceComposite)root).Add(subComposite);

        // Add children to subComposite
        ((InterfaceComposite)subComposite).Add(leaf2);
        ((InterfaceComposite)subComposite).Add(leaf3);

        // Perform operation
        root.Operation();
    }

    static void RunAbstractClassImplementation()
    {
        Console.WriteLine("\n--- Composite Pattern Using Abstract Class ---");
        AbstractComposite root = new AbstractComposite("Root");
        AbstractComponent leaf1 = new AbstractLeaf("Leaf1");
        AbstractComponent leaf2 = new AbstractLeaf("Leaf2");
        AbstractComposite subComposite = new AbstractComposite("SubComposite");
        AbstractComponent leaf3 = new AbstractLeaf("Leaf3");

        // Add children to root
        root.Add(leaf1);
        root.Add(subComposite);

        // Add children to subComposite
        subComposite.Add(leaf2);
        subComposite.Add(leaf3);

        // Perform operation
        root.Operation();
    }

    static void RunGenericsImplementation()
    {
        Console.WriteLine("\n--- Composite Pattern Using Generics ---");
        IGenericComposite root = new GenericComposite("Root");
        IGenericComponent leaf1 = new GenericLeaf("Leaf1");
        IGenericComponent leaf2 = new GenericLeaf("Leaf2");
        IGenericComposite subComposite = new GenericComposite("SubComposite");
        IGenericComponent leaf3 = new GenericLeaf("Leaf3");

        // Add children to root
        root.Add(leaf1);
        root.Add(subComposite);

        // Add children to subComposite
        subComposite.Add(leaf2);
        subComposite.Add(leaf3);

        // Perform operation
        root.Operation();
    }
}