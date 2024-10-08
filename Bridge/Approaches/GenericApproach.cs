using Bridge.DrawingAPI;
using Bridge.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Approaches
{
    public class Shape<T> where T : ShapeBase
    {
        private readonly IDrawAPI drawAPI;
        private readonly T shape;

        public Shape(IDrawAPI drawAPI, T shape)
        {
            this.drawAPI = drawAPI;
            this.shape = shape;
        }

        public void Draw()
        {
            drawAPI.DrawShape(shape.Name, shape.Color);
        }
    }
}
