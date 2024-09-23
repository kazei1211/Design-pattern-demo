using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
    abstract class Document
    {
        public abstract void Open();
        public abstract void Save();
    }
}
