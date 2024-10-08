using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DrawingAPI
{
    public class V1DrawingAPI : IDrawAPI
    {
        public void DrawShape(string shapeType, string color)
        {
            Console.WriteLine($"V1 Drawing {shapeType} in {color}");
        }
    }
}
