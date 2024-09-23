using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
    class JpgEditor : Application
    {
        protected override Document CreateDocument()
        {
            return new JpgDocument();
        }
    }
}
