using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Approaches
{
    public class OperationEventArgs : EventArgs
    {
        public string OperationName { get; set; }
    }

    public class FacadeWithEventHandler
    {
        public event EventHandler<OperationEventArgs> OnOperation;

        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;
        private SubsystemC _subsystemC;

        public FacadeWithEventHandler()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void PerformOperation()
        {
            OnOperation?.Invoke(this, new OperationEventArgs { OperationName = "SubsystemA" });
            _subsystemA.OperationA1();

            OnOperation?.Invoke(this, new OperationEventArgs { OperationName = "SubsystemB" });
            _subsystemB.OperationB1();

            OnOperation?.Invoke(this, new OperationEventArgs { OperationName = "SubsystemC" });
            _subsystemC.OperationC1();
        }
    }
}
