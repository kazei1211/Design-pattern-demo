using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    using System.Reflection;

    public abstract class TemplateWithReflection
    {
        public void ExecuteTemplateMethod()
        {
            InvokeStep("Step1");
            InvokeStep("Step2");
            InvokeStep("Step3");
        }

        private void InvokeStep(string methodName)
        {
            MethodInfo method = this.GetType().GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);
            method.Invoke(this, null);
        }

        protected void Step1()
        {
            Console.WriteLine("Step 1: Reflection-based execution");
        }

        protected abstract void Step2();

        protected void Step3()
        {
            Console.WriteLine("Step 3: Reflection-based execution");
        }
    }

    public class ConcreteClassWithReflection : TemplateWithReflection
    {
        protected override void Step2()
        {
            Console.WriteLine("Step 2: Overridden by ConcreteClassWithReflection");
        }
    }

}
