using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class ExceptionHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            try
            {
                if (request == "ERROR")
                {
                    throw new Exception("Exception occurred!");
                }
                else
                {
                    base.HandleRequest(request);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ExceptionHandler caught error: {ex.Message}");
            }
        }
    }

}
