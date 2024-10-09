using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class ConcreteHandlerA : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "A")
            {
                Console.WriteLine("Handler A handled the request.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }

}
