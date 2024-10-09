using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class VirtualProxy : ISubject
    {
        private RealSubject _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                Console.WriteLine("VirtualProxy: Creating RealSubject...");
                _realSubject = new RealSubject();
            }
            _realSubject.Request();
        }
    }
}
