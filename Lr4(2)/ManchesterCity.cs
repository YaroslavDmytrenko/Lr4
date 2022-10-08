using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class ManchesterCity : B
    {
        private string name = "Manchester City";
        private string league = "Premier League";
        public override void WriteInfo()
        {
            Console.WriteLine($"name:{name}");
            Console.WriteLine($"League: {league}");
        }
    }
}
