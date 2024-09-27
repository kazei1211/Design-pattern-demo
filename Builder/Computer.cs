using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        private List<string> _components = new List<string>();

        public void AddComponent(string component)
        {
            _components.Add(component);
        }

        public string ListComponents()
        {
            return "Computer Components: " + string.Join(", ", _components) + "\n";
        }
    }
}
