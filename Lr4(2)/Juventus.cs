using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Juventus : B
    {
        private string name = "Juventus";
        private string league = "Seria A";
        public override void WriteInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"League: {league}");
        }
    }
}
