using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public abstract class TemplateWithGenerics<T>
    {
        public void ExecuteTemplateMethod(T input)
        {
            Step1(input);
            Step2(input);
            Step3(input);
        }

        protected abstract void Step1(T input);
        protected abstract void Step2(T input);
        protected abstract void Step3(T input);
    }

    public class ConcreteClassWithGenerics : TemplateWithGenerics<int>
    {
        protected override void Step1(int input)
        {
            Console.WriteLine($"Step 1: Handling input {input}.");
        }

        protected override void Step2(int input)
        {
            Console.WriteLine($"Step 2: Handling input {input}.");
        }

        protected override void Step3(int input)
        {
            Console.WriteLine($"Step 3: Handling input {input}.");
        }
    }

}
