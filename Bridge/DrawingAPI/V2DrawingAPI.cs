using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DrawingAPI
{
    public class V2DrawingAPI : IDrawAPI
    {
        public void DrawShape(string shapeType, string color)
        {
            Console.WriteLine($"V2 Drawing {shapeType} in {color}");
        }
    }
}
