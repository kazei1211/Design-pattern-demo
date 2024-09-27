using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComputerDirector
    {
        private IComputerBuilder _builder;

        public IComputerBuilder Builder
        {
            set { _builder = value; }
        }

        // Constructs a complete computer by invoking builder methods in a specific order.
        public void BuildComputer()
        {
            _builder.AddCPU();
            _builder.AddGPU();
            _builder.AddRAM();
            _builder.AddStorage();
            _builder.AddCoolingSystem();
        }
    }
}
