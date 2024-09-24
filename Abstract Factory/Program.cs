using Abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory_design_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            IDocumentFactory factory;
            DocumentEditor editor;
            while (true)
            {
                Console.WriteLine("Select document type: ");
                Console.WriteLine("1. PDF");
                Console.WriteLine("2. DOCX");
                Console.WriteLine("3. TXT");
                Console.WriteLine("0. Exit");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        factory = new PdfFactory();
                        break;
                    case 2:
                        factory = new DocxFactory();
                        break;
                    case 3:
                        factory = new TxtFactory();
                        break;
                    case 0:
                        Console.WriteLine("Goodbye");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                }

                editor = new DocumentEditor(factory);
                editor.OpenDocument();
                editor.SaveDocument();

            }
        }
    }
}