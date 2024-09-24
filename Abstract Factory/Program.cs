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
            IDocumentFactory factory;
            DocumentEditor editor;

            Console.WriteLine("Select document type (1: PDF, 2: DOCX, 3: TXT): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    factory = new PdfFactory();
                    break;
                case "2":
                    factory = new DocxFactory();
                    break;
                case "3":
                    factory = new TxtFactory();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting.");
                    return;
            }

            editor = new DocumentEditor(factory);
            editor.OpenDocument();
            editor.SaveDocument();
        }
    }
}