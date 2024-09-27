using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CarBuilder
    {
        private string _make;
        private string _model;
        private int _year;
        private string _color;

        public CarBuilder SetMake(string make)
        {
            _make = make;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public CarBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        public Car Build()
        {
            return new Car(_make, _model, _year, _color);
        }
    }
}
