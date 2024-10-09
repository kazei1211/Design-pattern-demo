using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class PriorityHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            Console.WriteLine("PriorityHandler: Handling with priority.");
            base.HandleRequest(request);
        }
    }
}
