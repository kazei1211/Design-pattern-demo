﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void HandleRequest(string request);
    }

}
