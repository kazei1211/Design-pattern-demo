using Flyweight.Approaches;

namespace Flyweight
{
    public static class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the implementation method for the Flyweight Pattern:");
            Console.WriteLine("1. Use Interface and Abstract Class");
            Console.WriteLine("2. Use Delegate and Func<T>");
            Console.WriteLine("3. Use Generic");
            Console.WriteLine("4. Use Event Handler");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    RunInterfaceAndAbstractExample();
                    break;
                case 2:
                    RunDelegateExample();
                    break;
                case 3:
                    RunGenericExample();
                    break;
                case 4:
                    RunEventHandlerExample();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        private static void RunInterfaceAndAbstractExample()
        {
            IFlyweightFactoryFacade facade = new FlyweightFactoryFacadeWithInterface();
            facade.ExecuteFlyweightOperation("Circle", "Red");
            facade.ExecuteFlyweightOperation("Square", "Blue");
        }

        private static void RunDelegateExample()
        {
            FlyweightFactoryWithDelegate facade = new FlyweightFactoryWithDelegate();
            var operation = facade.GetFlyweightOperation("Rectangle");
            operation("Green");
        }

        private static void RunGenericExample()
        {
            FlyweightFactoryWithGeneric<ConcreteFlyweight> facade = new FlyweightFactoryWithGeneric<ConcreteFlyweight>();
            facade.ExecuteFlyweightOperation("Triangle", "Yellow");
        }

        private static void RunEventHandlerExample()
        {
            FlyweightFactoryWithEventHandler facade = new FlyweightFactoryWithEventHandler();
            facade.OnFlyweightOperation += (sender, args) =>
            {
                Console.WriteLine($"Handling operation for Flyweight {args.Key} with extrinsic state {args.ExtrinsicState}");
            };
            facade.ExecuteFlyweightOperation("Hexagon", "Purple");
        }
    }
}