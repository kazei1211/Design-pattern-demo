using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProtectionProxy : ISubject
    {
        private RealSubject _realSubject;
        private bool _hasAccess;

        public ProtectionProxy(bool hasAccess)
        {
            _realSubject = new RealSubject();
            _hasAccess = hasAccess;
        }

        public void Request()
        {
            if (_hasAccess)
            {
                _realSubject.Request();
            }
            else
            {
                Console.WriteLine("ProtectionProxy: Access denied.");
            }
        }
    }

}
