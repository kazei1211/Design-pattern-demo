using Factory_design_pattern;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            //menu
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Choose an editor:");
            Console.WriteLine("1. Photo Editor");
            Console.WriteLine("2. Graphic Editor");
            Console.WriteLine("3. Vector Design Editor");
            Console.Write("Enter your choice: ");
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            Console.WriteLine("-----------------------------------------");

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Exiting the program...");
                    break;
                case 1:
                    JpgDocument jpg = new JpgDocument();
                    jpg.Open();
                    jpg.Save();
                    Console.WriteLine();
                    break;
                case 2:
                    PngDocument png = new PngDocument();
                    png.Open();
                    png.Save();
                    Console.WriteLine();
                    break;
                case 3:
                    SvgDocument svg = new SvgDocument();
                    svg.Open();
                    svg.Save();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
