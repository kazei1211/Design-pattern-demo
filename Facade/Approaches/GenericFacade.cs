using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Approaches
{
    public class FacadeWithGeneric<T1, T2, T3>
        where T1 : SubsystemA, new()
        where T2 : SubsystemB, new()
        where T3 : SubsystemC, new()
    {
        private readonly T1 _subsystemA;
        private readonly T2 _subsystemB;
        private readonly T3 _subsystemC;

        public FacadeWithGeneric()
        {
            _subsystemA = new T1();
            _subsystemB = new T2();
            _subsystemC = new T3();
        }

        public void PerformOperation()
        {
            _subsystemA.OperationA1();
            _subsystemB.OperationB1();
            _subsystemC.OperationC1();
        }
    }
}
