using State;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        Context basicContext = new Context(new ConcreteStateA());
        EnumContext enumContext = new EnumContext(StateType.StateA);
        SwitchContext switchContext = new SwitchContext("StateA");
        ReflectionContext reflectionContext = new ReflectionContext("StateA");
        StrategyContext strategyContext = new StrategyContext(new StrategyA());

        while (runProgram)
        {
            Console.WriteLine("Choose a State Implementation:");
            Console.WriteLine("1. Basic State");
            Console.WriteLine("2. Enum State");
            Console.WriteLine("3. Switch State");
            Console.WriteLine("4. Reflection State");
            Console.WriteLine("5. Strategy State");
            Console.WriteLine("6. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    basicContext.Request();
                    break;
                case "2":
                    enumContext.Request();
                    break;
                case "3":
                    switchContext.Request();
                    break;
                case "4":
                    reflectionContext.Request();
                    break;
                case "5":
                    strategyContext.Request();
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
