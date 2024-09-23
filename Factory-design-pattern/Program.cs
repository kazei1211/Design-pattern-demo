using System;

// Abstract Document (File) Class
abstract class Document
{
    public abstract void Open();
    public abstract void Save();
}

// Concrete Document Classes
class JpgDocument : Document
{
    public override void Open()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Opening a .jpg photo...");
        Console.ResetColor();
    }

    public override void Save()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Saving a .jpg photo...");
        Console.ResetColor();
    }
}

class PngDocument : Document
{
    public override void Open()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Opening a .png graphic...");
        Console.ResetColor();
    }

    public override void Save()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Saving a .png graphic...");
        Console.ResetColor();
    }
}

class SvgDocument : Document
{
    public override void Open()
    {
        //chang console font color
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Opening a .svg vector design...");
        Console.ResetColor();
    }

    public override void Save()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Saving a .svg vector design...");
        Console.ResetColor();
    }
}

// Abstract Application (Editor) Class
abstract class Application
{
    public void OpenDocument()
    {
        Document doc = CreateDocument();
        doc.Open();
    }

    public void SaveDocument()
    {
        Document doc = CreateDocument();
        doc.Save();
    }

    // Factory Method
    protected abstract Document CreateDocument();
}

// Concrete Application Classes (Photo Editor, Graphic Editor)
class JpgEditor : Application
{
    protected override Document CreateDocument()
    {
        return new JpgDocument();
    }
}

class PngEditor : Application
{
    protected override Document CreateDocument()
    {
        return new PngDocument();
    }
}

class SvgEditor : Application
{
    protected override Document CreateDocument()
    {
        return new SvgDocument();
    }
}

// Main Simulation
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
                    Console.WriteLine(
                    "Exiting the program...");
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
                    Console.WriteLine(
                    "Invalid choice. Please try again."); break;

            }
        }
    }
}
