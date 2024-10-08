using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Approaches
{
    public class ShapeEventArgs : EventArgs
    {
        public string ShapeType { get; }
        public string Color { get; }

        public ShapeEventArgs(string shapeType, string color)
        {
            ShapeType = shapeType;
            Color = color;
        }
    }

    public class ShapeWithEvent
    {
        public event EventHandler<ShapeEventArgs> OnDraw;

        private string shapeType;
        private string color;

        public ShapeWithEvent(string shapeType, string color)
        {
            this.shapeType = shapeType;
            this.color = color;
        }

        public void Draw()
        {
            OnDraw?.Invoke(this, new ShapeEventArgs(shapeType, color));
        }
    }
}
