using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
    class SvgEditor : Application
    {
        protected override Document CreateDocument()
        {
            return new SvgDocument();
        }
    }
}
