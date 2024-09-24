using Factory_design_pattern;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        Application editor;
        while (choice != 0)
        {
            //menu
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Choose an editor:");
            Console.WriteLine("1. Photo Editor");
            Console.WriteLine("2. Graphic Editor");
            Console.WriteLine("3. Vector Design Editor");
            Console.WriteLine("0. Exit");
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
                    editor = new JpgEditor();
                    editor.OpenDocument();
                    editor.SaveDocument();
                    Console.WriteLine();
                    break;
                case 2:
                    editor = new PngEditor();
                    editor.OpenDocument();
                    editor.SaveDocument();
                    Console.WriteLine();
                    break;
                case 3:
                    editor = new SvgEditor();
                    editor.OpenDocument();
                    editor.SaveDocument();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
