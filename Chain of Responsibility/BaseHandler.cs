using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public abstract class BaseHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }

        public virtual void HandleRequest(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
