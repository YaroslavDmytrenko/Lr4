using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class Barcelona : B
    {
        private string name = "Barcelona";
        private string league = "LaLiga";
        public override void WriteInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"League: {league}");
        }
    }
}
