using Facade.Approaches;
using Facade.Subsystems;

namespace Facade
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the implementation method for the Facade Pattern:");
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
            IFacade facade = new FacadeWithInterfaceAndAbstract();
            facade.PerformOperation();
        }

        private static void RunDelegateExample()
        {
            FacadeWithDelegate facade = new FacadeWithDelegate(DelegateOperations.PerformSubsystemOperations);
            facade.PerformOperation();
        }

        private static void RunGenericExample()
        {
            FacadeWithGeneric<SubsystemA, SubsystemB, SubsystemC> facade = new FacadeWithGeneric<SubsystemA, SubsystemB, SubsystemC>();
            facade.PerformOperation();
        }

        private static void RunEventHandlerExample()
        {
            FacadeWithEventHandler facade = new FacadeWithEventHandler();
            facade.OnOperation += (sender, args) =>
            {
                Console.WriteLine($"Executing operation: {args.OperationName}");
            };
            facade.PerformOperation();
        }
    }
}
    