using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IComputerBuilder
    {
        void AddCPU();
        void AddGPU();
        void AddRAM();
        void AddStorage();
        void AddCoolingSystem();
        Computer GetComputer();
    }
}
