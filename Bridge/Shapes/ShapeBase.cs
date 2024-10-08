using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Shapes
{
    public abstract class ShapeBase
    {
        public string Color { get; set; }
        public string Name { get; set; }

        public ShapeBase(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public abstract void Draw();
    }
}
