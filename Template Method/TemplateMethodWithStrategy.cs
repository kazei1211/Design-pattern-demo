using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    public interface IStrategyStep
    {
        void Execute();
    }

    public class Step1Strategy : IStrategyStep
    {
        public void Execute()
        {
            Console.WriteLine("Step 1: Executed via Strategy");
        }
    }

    public class Step2Strategy : IStrategyStep
    {
        public void Execute()
        {
            Console.WriteLine("Step 2: Executed via Strategy");
        }
    }

    public abstract class TemplateWithStrategy
    {
        protected IStrategyStep _step1;
        protected IStrategyStep _step2;

        public TemplateWithStrategy(IStrategyStep step1, IStrategyStep step2)
        {
            _step1 = step1;
            _step2 = step2;
        }

        public void ExecuteTemplateMethod()
        {
            _step1.Execute();
            _step2.Execute();
            Step3();
        }

        protected virtual void Step3()
        {
            Console.WriteLine("Step 3: Basic Implementation");
        }
    }

    public class ConcreteTemplateWithStrategy : TemplateWithStrategy
    {
        public ConcreteTemplateWithStrategy(IStrategyStep step1, IStrategyStep step2)
            : base(step1, step2) { }

        protected override void Step3()
        {
            Console.WriteLine("Step 3: Overridden Implementation");
        }
    }

}
