using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class DocxDocument : IDocument
    {
        public void Open()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Opening a DOCX document...");
            Console.ResetColor();
        }

        public void Save()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Saving a DOCX document...");
            Console.ResetColor();
        }
    }
}
