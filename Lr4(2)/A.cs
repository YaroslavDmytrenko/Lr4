using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second
{
    internal class A
    {
        public A(B club1, B club2)
        {
            Console.WriteLine(club1);
            Console.WriteLine(club2);
        }

        public A(B club1, B club2, B club3)
        {
            Console.WriteLine(club1);
            Console.WriteLine(club2);
            Console.WriteLine(club3);
        }
    }
}
