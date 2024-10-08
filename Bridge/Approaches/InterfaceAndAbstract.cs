using Bridge.DrawingAPI;
using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Approaches
{
    public class ShapeWithBridge : IShape
    {
        private readonly IDrawAPI drawAPI;
        private readonly string shapeType;
        private readonly string color;

        public ShapeWithBridge(IDrawAPI drawAPI, string shapeType, string color)
        {
            this.drawAPI = drawAPI;
            this.shapeType = shapeType;
            this.color = color;
        }

        public void Draw()
        {
            drawAPI.DrawShape(shapeType, color);
        }
    }
}
