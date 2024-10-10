using Strategy;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        // Basic Strategy Setup
        Context basicContext = new Context();
        StrategyA strategyA = new StrategyA();
        StrategyB strategyB = new StrategyB();

        // Delegate Strategy Setup
        DelegateContext delegateContext = new DelegateContext();
        StrategyWithDelegates strategyDelegate = new StrategyWithDelegates();

        // Func Strategy Setup
        FuncContext funcContext = new FuncContext();
        FuncStrategies funcStrategies = new FuncStrategies();

        // Dependency Injection Strategy Setup
        DIContext diContextA = new DIContext(new StrategyDI_A());
        DIContext diContextB = new DIContext(new StrategyDI_B());

        // Dynamic Strategy Setup
        DynamicStrategyContext dynamicContext = new DynamicStrategyContext();

        while (runProgram)
        {
            Console.WriteLine("Choose a Strategy Pattern Implementation:");
            Console.WriteLine("1. Basic Strategy");
            Console.WriteLine("2. Delegate Strategy");
            Console.WriteLine("3. Func Strategy");
            Console.WriteLine("4. Dependency Injection Strategy");
            Console.WriteLine("5. Dynamic Strategy Selection");
            Console.WriteLine("6. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    basicContext.SetStrategy(strategyA);
                    basicContext.ExecuteStrategy();

                    basicContext.SetStrategy(strategyB);
                    basicContext.ExecuteStrategy();
                    break;
                case "2":
                    delegateContext.SetStrategy(strategyDelegate.ExecuteA);
                    delegateContext.ExecuteStrategy();

                    delegateContext.SetStrategy(strategyDelegate.ExecuteB);
                    delegateContext.ExecuteStrategy();
                    break;
                case "3":
                    funcContext.SetStrategy(funcStrategies.ExecuteA);
                    funcContext.RunStrategy();

                    funcContext.SetStrategy(funcStrategies.ExecuteB);
                    funcContext.RunStrategy();
                    break;
                case "4":
                    diContextA.ExecuteStrategy();
                    diContextB.ExecuteStrategy();
                    break;
                case "5":
                    dynamicContext.SetStrategyBasedOnCondition(true);
                    dynamicContext.ExecuteStrategy();

                    dynamicContext.SetStrategyBasedOnCondition(false);
                    dynamicContext.ExecuteStrategy();
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

