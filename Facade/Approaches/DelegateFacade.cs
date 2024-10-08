using Facade.Subsystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Approaches
{
    public delegate void OperationDelegate();

    public class FacadeWithDelegate
    {
        private readonly OperationDelegate _operation;

        public FacadeWithDelegate(OperationDelegate operation)
        {
            _operation = operation;
        }

        public void PerformOperation()
        {
            _operation();
        }
    }

    // Facade sử dụng Delegate
    public static class DelegateOperations
    {
        public static void PerformSubsystemOperations()
        {
            SubsystemA a = new SubsystemA();
            SubsystemB b = new SubsystemB();
            SubsystemC c = new SubsystemC();

            a.OperationA1();
            b.OperationB1();
            c.OperationC1();
        }
    }
}
