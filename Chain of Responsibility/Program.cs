using Chain_of_Responsibility;
using System;

class Program
{
    static void Main(string[] args)
    {
        IHandler handlerChain = null;
        bool runProgram = true;

        while (runProgram)
        {
            Console.WriteLine("Choose a Chain of Responsibility Implementation:");
            Console.WriteLine("1. Basic Chain");
            Console.WriteLine("2. Chain with Break Condition");
            Console.WriteLine("3. Chain with Result Returning");
            Console.WriteLine("4. Chain with Exception Handling");
            Console.WriteLine("5. Chain with Logging");
            Console.WriteLine("6. Chain with Priority");
            Console.WriteLine("7. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    handlerChain = new ConcreteHandlerA();
                    handlerChain.SetNext(new ConcreteHandlerB());
                    break;
                case "2":
                    handlerChain = new ConcreteHandlerA();
                    handlerChain.SetNext(new BreakableHandler()).SetNext(new ConcreteHandlerB());
                    break;
                case "3":
                    handlerChain = new ConcreteHandlerA();
                    handlerChain.SetNext(new ResultHandler()).SetNext(new ConcreteHandlerB());
                    break;
                case "4":
                    handlerChain = new ConcreteHandlerA();
                    handlerChain.SetNext(new ExceptionHandler()).SetNext(new ConcreteHandlerB());
                    break;
                case "5":
                    handlerChain = new LoggingHandler();
                    handlerChain.SetNext(new ConcreteHandlerB());
                    break;
                case "6":
                    handlerChain = new PriorityHandler();
                    handlerChain.SetNext(new ConcreteHandlerA()).SetNext(new ConcreteHandlerB());
                    break;
                case "7":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            Console.WriteLine("Enter a request (A, B, C, BREAK, ERROR):");
            string request = Console.ReadLine();
            handlerChain.HandleRequest(request);
        }
    }
}
