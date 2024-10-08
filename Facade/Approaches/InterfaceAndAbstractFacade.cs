using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Approaches
{
    public interface IFacade
    {
        void PerformOperation();
    }

    public class FacadeWithInterfaceAndAbstract : IFacade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;
        private SubsystemC _subsystemC;

        public FacadeWithInterfaceAndAbstract()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void PerformOperation()
        {
            _subsystemA.OperationA1();
            _subsystemB.OperationB1();
            _subsystemC.OperationC1();
        }
    }
}
