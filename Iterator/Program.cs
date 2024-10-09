using Iterator;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> collection = new List<string> { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
        IIterator<string> iterator = null;
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Choose an Iterator Implementation:");
            Console.WriteLine("1. Basic Iterator");
            Console.WriteLine("2. Reverse Iterator");
            Console.WriteLine("3. Filter Iterator (Items containing '1')");
            Console.WriteLine("4. Bidirectional Iterator");
            Console.WriteLine("5. Random Access Iterator");
            Console.WriteLine("6. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    iterator = new ConcreteIterator<string>(collection);
                    break;
                case "2":
                    iterator = new ReverseIterator<string>(collection);
                    break;
                case "3":
                    iterator = new FilterIterator<string>(collection, item => item.Contains("1"));
                    break;
                case "4":
                    var bidiIterator = new BidirectionalIterator<string>(collection);
                    iterator = bidiIterator;
                    break;
                case "5":
                    iterator = new RandomIterator<string>(collection);
                    break;
                case "6":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine("Iterating over collection:");
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Current());
                iterator.Next();
            }
        }
    }
}