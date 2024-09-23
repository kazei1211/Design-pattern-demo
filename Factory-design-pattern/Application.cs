using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_design_pattern
{
    abstract class Application
    {
        public void OpenDocument()
        {
            Document doc = CreateDocument();
            doc.Open();
        }

        public void SaveDocument()
        {
            Document doc = CreateDocument();
            doc.Save();
        }

        // Factory Method
        protected abstract Document CreateDocument();
    }
}
