using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Car
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }

        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public override string ToString()
        {
            return $"Car: {Year} {Make} {Model} in {Color}";
        }
    }
}
