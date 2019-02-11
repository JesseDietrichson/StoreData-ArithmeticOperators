using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 5 + 5;
            myInt = 5 * 5;
            myInt = 5 / 5;
            myInt = 5 - 5;


            int test = 10 / 3;
            Console.WriteLine(test);

            double test2 = 10.0 / 3.0;
            Console.WriteLine(test2);

            int remainder = 10 % 3;
            Console.WriteLine(remainder);

        }
    }
}
