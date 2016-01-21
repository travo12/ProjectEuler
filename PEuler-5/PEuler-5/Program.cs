using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int divnumber = 0;

            int i = 20;
            while (true)
            {
                if (testdivisible(i))
                {
                    if (divnumber < i) divnumber = i;
                    break;
                }
                i +=20;
            }

            Console.WriteLine("The answer is " + divnumber);
            Console.Read();

        }

        static bool testdivisible(int testnum)
        {
            for (int j = 2; j <= 20; j++)
            {
                if (testnum % j != 0) return false;
            }
            return true;
        }

    }
}
