using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void AddCPU()
        {
            _computer.AddComponent("High-End CPU (e.g., Intel i9)");
        }

        public void AddGPU()
        {
            _computer.AddComponent("Dedicated GPU (e.g., NVIDIA RTX 3080)");
        }

        public void AddRAM()
        {
            _computer.AddComponent("32GB DDR4 RAM");
        }

        public void AddStorage()
        {
            _computer.AddComponent("1TB NVMe SSD");
        }

        public void AddCoolingSystem()
        {
            _computer.AddComponent("Liquid Cooling System");
        }

        public Computer GetComputer()
        {
            Computer result = _computer;
            _computer = new Computer(); // Reset for next build
            return result;
        }
    }
}
