using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealSubject : ISubject
    {
        public RealSubject()
        {
            Console.WriteLine("RealSubject: Initialized");
        }

        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request");
        }
    }

}
