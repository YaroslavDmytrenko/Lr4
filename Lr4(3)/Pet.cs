using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Pet
    {
       private int _age;
       private string _name;
       private string colour;
       public virtual int Age
        {
            get { 
                return _age; 
            }
            set { 
                _age = value; 
            }
        }

        public virtual string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Pet(int age, string name)        {
            _age = age;
            _name = name;
        }

    }
}
