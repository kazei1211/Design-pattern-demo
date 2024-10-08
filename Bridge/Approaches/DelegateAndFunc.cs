using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Approaches
{
    public delegate void DrawDelegate(string shapeType, string color);

    public class ShapeWithDelegate
    {
        private readonly DrawDelegate drawDelegate;
        private readonly string shapeType;
        private readonly string color;

        public ShapeWithDelegate(string shapeType, string color, DrawDelegate drawDelegate)
        {
            this.shapeType = shapeType;
            this.color = color;
            this.drawDelegate = drawDelegate;
        }

        public void Draw()
        {
            drawDelegate(shapeType, color);
        }
    }
}
