using Bridge.Approaches;
using Bridge.DrawingAPI;
using Bridge.Shapes;

namespace Bridge
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Choose the implementation method for the Bridge Pattern:");
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
                    RunDelegateAndFuncExample();
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
            IDrawAPI api = new V1DrawingAPI();
            var shape = new ShapeWithBridge(api, "Circle", "Red");
            shape.Draw();
        }

        private static void RunDelegateAndFuncExample()
        {
            DrawDelegate drawDelegate = (shapeType, color) =>
            {
                Console.WriteLine($"Drawing {shapeType} in {color} using Delegate");
            };
            var shape = new ShapeWithDelegate("Rectangle", "Blue", drawDelegate);
            shape.Draw();
        }

        private static void RunGenericExample()
        {
            IDrawAPI api = new V1DrawingAPI();
            var circle = new Circle(10, "Green");
            var shape = new Shape<Circle>(api, circle);
            shape.Draw();
        }

        private static void RunEventHandlerExample()
        {
            var shape = new ShapeWithEvent("Rectangle", "Yellow");
            shape.OnDraw += (sender, args) =>
            {
                Console.WriteLine($"Drawing {args.ShapeType} in {args.Color} using Event Handler");
            };
            shape.Draw();
        }
    }
}