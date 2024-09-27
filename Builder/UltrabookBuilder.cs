using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class UltrabookBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void AddCPU()
        {
            _computer.AddComponent("Power-Efficient CPU (e.g., Intel i7 U-Series)");
        }

        public void AddGPU()
        {
            _computer.AddComponent("Integrated GPU with Low Power Consumption");
        }

        public void AddRAM()
        {
            _computer.AddComponent("16GB LPDDR4 RAM");
        }

        public void AddStorage()
        {
            _computer.AddComponent("512GB NVMe SSD");
        }

        public void AddCoolingSystem()
        {
            _computer.AddComponent("Passive Cooling System");
        }

        public Computer GetComputer()
        {
            Computer result = _computer;
            _computer = new Computer(); // Reset for next build
            return result;
        }
    }
}
