using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartProxy : ISubject
    {
        private RealSubject _realSubject = new RealSubject();

        public void Request()
        {
            Console.WriteLine("SmartProxy: Logging before request...");
            _realSubject.Request();
            Console.WriteLine("SmartProxy: Logging after request...");
        }
    }
}
