using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public class Rectangle : ShapeBase
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height, string color) : base("Rectangle", color)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} Rectangle with width {Width} and height {Height}");
        }
    }
}
