using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
    class SvgDocument : Document
    {
        public override void Open()
        {
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
}
