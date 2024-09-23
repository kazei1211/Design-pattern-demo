using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
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
}
