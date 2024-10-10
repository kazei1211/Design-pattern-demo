using System;
using Visitor;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        // Basic Visitor Setup
        IElement elementA = new ElementA();
        IElement elementB = new ElementB();
        IVisitor visitor = new ConcreteVisitor();

        // Double Dispatch Visitor Setup
        IVisitable advancedElementA = new AdvancedElementA();
        IVisitable advancedElementB = new AdvancedElementB();
        IAdvancedVisitor doubleDispatchVisitor = new DoubleDispatchVisitor();

        // Reflection Visitor Setup
        ReflectionVisitor reflectionVisitor = new ReflectionVisitor();

        // Fluent Visitor Setup
        FluentVisitor fluentVisitor = new FluentVisitor();

        // Generic Visitor Setup
        GenericVisitor genericVisitor = new GenericVisitor();
        IGenericElement<ElementA> genericElementA = new GenericElementA();
        IGenericElement<ElementB> genericElementB = new GenericElementB();

        while (runProgram)
        {
            Console.WriteLine("Choose a Visitor Pattern Implementation:");
            Console.WriteLine("1. Basic Visitor");
            Console.WriteLine("2. Double Dispatch Visitor");
            Console.WriteLine("3. Reflection Visitor");
            Console.WriteLine("4. Fluent Visitor");
            Console.WriteLine("5. Generic Visitor");
            Console.WriteLine("6. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    elementA.Accept(visitor);
                    elementB.Accept(visitor);
                    break;
                case "2":
                    advancedElementA.Accept(doubleDispatchVisitor);
                    advancedElementB.Accept(doubleDispatchVisitor);
                    break;
                case "3":
                    reflectionVisitor.Visit(elementA);
                    reflectionVisitor.Visit(elementB);
                    break;
                case "4":
                    fluentVisitor.Visit((ElementA)elementA).Visit((ElementB)elementB);
                    break;
                case "5":
                    genericElementA.Accept(genericVisitor);
                    genericElementB.Accept(genericVisitor);
                    break;
                case "6":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}
