using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Third
{
    internal class Deb<T> where T : Pet
    {
        public void DebugResult(T pet)
        {
            Debug.WriteLine($"Pet name: {pet.Name}, age : {pet.Age}");
            Console.WriteLine($"Pet name: {pet.Name}, age : {pet.Age}");
        }
    }
}
