using Decorator;
using Decorator.Interfaces;
using System;
using Decorator.Decorators;
using Decorator.AbstractDecorators;
using Decorator.Generics;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a Decorator Pattern implementation:");
                Console.WriteLine("1. Using Interface");
                Console.WriteLine("2. Using Abstract Class");
                Console.WriteLine("3. Using Generics");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 2.\n");
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
            Console.WriteLine("\n--- Decorator Pattern Using Interface ---");

            IComponent simple = new ConcreteComponent();
            Console.WriteLine($"Simple: {simple.Operation()}");

            IComponent decoratorA = new ConcreteDecoratorA(simple);
            Console.WriteLine($"DecoratorA: {decoratorA.Operation()}");

            IComponent decoratorB = new ConcreteDecoratorB(decoratorA);
            Console.WriteLine($"DecoratorB: {decoratorB.Operation()}");
        }

        static void RunAbstractClassImplementation()
        {
            Console.WriteLine("\n--- Decorator Pattern Using Abstract Class ---");

            IComponent simple = new ConcreteComponent();
            Console.WriteLine($"Simple: {simple.Operation()}");

            IComponent decoratorA = new ConcreteAbstractDecoratorA(simple);
            Console.WriteLine($"DecoratorA: {decoratorA.Operation()}");

            IComponent decoratorB = new ConcreteAbstractDecoratorB(decoratorA);
            Console.WriteLine($"DecoratorB: {decoratorB.Operation()}");
        }

        static void RunGenericsImplementation()
        {
            Console.WriteLine("\n--- Decorator Pattern Using Generics ---");

            // Tạo đối tượng gốc
            IComponent simple = new ConcreteComponent();
            Console.WriteLine($"Simple: {simple.Operation()}");

            // Bọc bằng GenericConcreteDecoratorA
            IComponent decoratorA = new GenericConcreteDecoratorA<IComponent>(simple);
            Console.WriteLine($"DecoratorA: {decoratorA.Operation()}");
            ((GenericConcreteDecoratorA<IComponent>)decoratorA).AddedBehavior();

            // Bọc thêm bằng GenericConcreteDecoratorB
            IComponent decoratorB = new GenericConcreteDecoratorB<IComponent>(decoratorA);
            Console.WriteLine($"DecoratorB: {decoratorB.Operation()}");
            ((GenericConcreteDecoratorB<IComponent>)decoratorB).AnotherAddedBehavior();
        }
    }
}