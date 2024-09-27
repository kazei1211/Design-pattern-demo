using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FluentComputerBuilder
    {
        private Computer _computer = new Computer();

        public FluentComputerBuilder AddCPU(string cpu)
        {
            _computer.AddComponent(cpu);
            return this;
        }

        public FluentComputerBuilder AddGPU(string gpu)
        {
            _computer.AddComponent(gpu);
            return this;
        }

        public FluentComputerBuilder AddRAM(string ram)
        {
            _computer.AddComponent(ram);
            return this;
        }

        public FluentComputerBuilder AddStorage(string storage)
        {
            _computer.AddComponent(storage);
            return this;
        }

        public Computer Build()
        {
            Computer result = _computer;
            _computer = new Computer(); // Reset for next build
            return result;
        }
    }
}
