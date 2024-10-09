using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class BasicTemplate
    {
        public void ExecuteTemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        protected virtual void Step1()
        {
            Console.WriteLine("Step 1: Basic Implementation");
        }

        protected abstract void Step2();

        protected virtual void Step3()
        {
            Console.WriteLine("Step 3: Basic Implementation");
        }
    }

    public class ConcreteClassA : BasicTemplate
    {
        protected override void Step2()
        {
            Console.WriteLine("Step 2: Implementation by Class A");
        }
    }

    public class ConcreteClassB : BasicTemplate
    {
        protected override void Step2()
        {
            Console.WriteLine("Step 2: Implementation by Class B");
        }
    }

}
