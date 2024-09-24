using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class TxtDocument : IDocument
    {
        public void Open()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Opening a TXT document...");
            Console.ResetColor();
        }

        public void Save()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Saving a TXT document...");
            Console.ResetColor();
        }
    }
}
