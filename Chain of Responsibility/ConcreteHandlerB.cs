using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class ConcreteHandlerB : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "B")
            {
                Console.WriteLine("Handler B handled the request.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }

}
