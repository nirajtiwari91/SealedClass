using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCal = new Calculator();
            Console.WriteLine(objCal.Sum(5, 4));
            Console.ReadLine();
        }
    }
}
