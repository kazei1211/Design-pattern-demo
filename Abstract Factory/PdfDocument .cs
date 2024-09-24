using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class PdfDocument : IDocument
    {
        public void Open()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Opening a PDF document...");
            Console.ResetColor();
        }

        public void Save()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Saving a PDF document...");
            Console.ResetColor();
        }
    }
}
