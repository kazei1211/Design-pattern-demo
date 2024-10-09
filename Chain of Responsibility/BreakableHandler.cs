using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class BreakableHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "BREAK")
            {
                Console.WriteLine("BreakableHandler: Stopping chain.");
                return; // Stop chain here
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
