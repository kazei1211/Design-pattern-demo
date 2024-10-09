using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class TemplateWithHook
    {
        public void ExecuteTemplateMethod()
        {
            Step1();
            Step2();
            if (Hook())
            {
                Step3();
            }
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

        // Hook method with default implementation
        protected virtual bool Hook()
        {
            return true;
        }
    }

    public class ConcreteClassWithHookA : TemplateWithHook
    {
        protected override void Step2()
        {
            Console.WriteLine("Step 2: Implementation by Class A");
        }

        protected override bool Hook()
        {
            // Overriding hook to skip Step 3
            return false;
        }
    }

    public class ConcreteClassWithHookB : TemplateWithHook
    {
        protected override void Step2()
        {
            Console.WriteLine("Step 2: Implementation by Class B");
        }
    }

}
