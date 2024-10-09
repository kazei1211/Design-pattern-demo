using System;
using Template_Method;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        BasicTemplate classA = new ConcreteClassA();
        BasicTemplate classB = new ConcreteClassB();
        TemplateWithHook hookClassA = new ConcreteClassWithHookA();
        TemplateWithHook hookClassB = new ConcreteClassWithHookB();
        TemplateWithStrategy strategyClass = new ConcreteTemplateWithStrategy(new Step1Strategy(), new Step2Strategy());
        TemplateWithReflection reflectionClass = new ConcreteClassWithReflection();
        TemplateWithGenerics<int> genericClass = new ConcreteClassWithGenerics();

        while (runProgram)
        {
            Console.WriteLine("Choose a Template Method Implementation:");
            Console.WriteLine("1. Basic Template Method (Class A)");
            Console.WriteLine("2. Basic Template Method (Class B)");
            Console.WriteLine("3. Template Method with Hook (Class A)");
            Console.WriteLine("4. Template Method with Hook (Class B)");
            Console.WriteLine("5. Template Method with Strategy");
            Console.WriteLine("6. Template Method with Reflection");
            Console.WriteLine("7. Template Method with Generics");
            Console.WriteLine("8. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    classA.ExecuteTemplateMethod();
                    break;
                case "2":
                    classB.ExecuteTemplateMethod();
                    break;
                case "3":
                    hookClassA.ExecuteTemplateMethod();
                    break;
                case "4":
                    hookClassB.ExecuteTemplateMethod();
                    break;
                case "5":
                    strategyClass.ExecuteTemplateMethod();
                    break;
                case "6":
                    reflectionClass.ExecuteTemplateMethod();
                    break;
                case "7":
                    genericClass.ExecuteTemplateMethod(42);
                    break;
                case "8":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}