using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal abstract class B
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        public virtual void WriteInfo()
        {
            Console.WriteLine($"Name:{name}");
        }
    }
}
