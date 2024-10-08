using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.DrawingAPI
{
    public interface IDrawAPI
    {
        void DrawShape(string shapeType, string color);
    }
}
