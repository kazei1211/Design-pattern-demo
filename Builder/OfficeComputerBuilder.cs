using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void AddCPU()
        {
            _computer.AddComponent("Mid-Range CPU (e.g., Intel i5)");
        }

        public void AddGPU()
        {
            _computer.AddComponent("Integrated GPU");
        }

        public void AddRAM()
        {
            _computer.AddComponent("16GB DDR4 RAM");
        }

        public void AddStorage()
        {
            _computer.AddComponent("512GB SSD");
        }

        public void AddCoolingSystem()
        {
            _computer.AddComponent("Standard Air Cooling");
        }

        public Computer GetComputer()
        {
            Computer result = _computer;
            _computer = new Computer(); // Reset for next build
            return result;
        }
    }
}
