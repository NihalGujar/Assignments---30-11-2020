using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
     class Child : Parent
    {
        public override int ADD(int a, int b)
        {
            return a - b;
        }

        
    }
}
