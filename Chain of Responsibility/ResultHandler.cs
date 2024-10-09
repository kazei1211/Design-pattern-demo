using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class ResultHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            string result = ProcessRequest(request);
            if (result != null)
            {
                Console.WriteLine($"ResultHandler processed request: {result}");
            }
            else
            {
                base.HandleRequest(request);
            }
        }

        private string ProcessRequest(string request)
        {
            if (request == "C")
            {
                return "Handled by ResultHandler";
            }
            return null;
        }
    }

}
