using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RemoteProxy : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RemoteProxy: Forwarding request to remote object...");
            // Simulate remote communication
        }
    }

}
