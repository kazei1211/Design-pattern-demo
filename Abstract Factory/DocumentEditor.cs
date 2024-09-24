using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    public class DocumentEditor
    {
        private IDocument _document;

        public DocumentEditor(IDocumentFactory factory)
        {
            _document = factory.CreateDocument();
        }

        public void OpenDocument()
        {
            _document.Open();
        }

        public void SaveDocument()
        {
            _document.Save();
        }
    }
}
