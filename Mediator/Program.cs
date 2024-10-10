using Mediator;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;

        // Basic Mediator Setup
        ComponentA componentA = new ComponentA();
        ComponentB componentB = new ComponentB();
        BasicMediator basicMediator = new BasicMediator(componentA, componentB);

        // Event Aggregator Setup
        EventAggregator eventAggregator = new EventAggregator();
        EventComponentA eventComponentA = new EventComponentA(eventAggregator);
        EventComponentB eventComponentB = new EventComponentB(eventAggregator);

        // Colleague Mediator Setup
        ColleagueA colleagueA = new ColleagueA();
        ColleagueB colleagueB = new ColleagueB();
        ColleagueMediator colleagueMediator = new ColleagueMediator();
        colleagueA.SetMediator(colleagueMediator);
        colleagueB.SetMediator(colleagueMediator);

        // Dynamic Mediator Setup
        DynamicMediator dynamicMediator = new DynamicMediator();
        DynamicComponent dynamicComponentA = new DynamicComponent { Name = "ComponentA" };
        DynamicComponent dynamicComponentB = new DynamicComponent { Name = "ComponentB" };
        dynamicMediator.Register(dynamicComponentA);
        dynamicMediator.Register(dynamicComponentB);

        while (runProgram)
        {
            Console.WriteLine("Choose a Mediator Pattern Implementation:");
            Console.WriteLine("1. Basic Mediator (Component A triggers Component B)");
            Console.WriteLine("2. Event Aggregator Mediator (Trigger Event A)");
            Console.WriteLine("3. Colleague Mediator (Colleague A sends message)");
            Console.WriteLine("4. Dynamic Mediator (Component A triggers notification)");
            Console.WriteLine("5. Exit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    componentA.DoA();
                    break;
                case "2":
                    eventAggregator.Publish("A");
                    break;
                case "3":
                    colleagueA.SendMessage("Hello from A");
                    break;
                case "4":
                    dynamicComponentA.DoSomething();
                    break;
                case "5":
                    runProgram = false;
                    continue;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }
        }
    }
}
