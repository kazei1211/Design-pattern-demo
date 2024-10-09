using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class CachingProxy : ISubject
    {
        private RealSubject _realSubject;
        private string _cachedData;

        public void Request()
        {
            if (_cachedData == null)
            {
                Console.WriteLine("CachingProxy: Fetching data from RealSubject...");
                _realSubject = new RealSubject();
                _realSubject.Request();
                _cachedData = "Cached data from RealSubject";
            }
            else
            {
                Console.WriteLine("CachingProxy: Returning cached data: " + _cachedData);
            }
        }
    }

}
