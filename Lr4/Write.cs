using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace First
{
    internal class Write<T>
    {
        public void Show(T one)
        {
            Debug.WriteLine(one);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{one.GetType()} = {one}");
        }
    }
}
