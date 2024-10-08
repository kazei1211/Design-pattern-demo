using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Circle : ShapeBase
    {
        public int Radius { get; set; }

        public Circle(int radius, string color) : base("Circle", color)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Circle with radius {Radius}");
        }
    }
}
