using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    //sealed class
    public sealed class Calculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
