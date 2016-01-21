using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nthprime = 0;
            int primesfound = 0;
            for (int i = 2; primesfound < 10001; i++)
            {
                if (findprime(i))
                {
                    nthprime = i;
                    primesfound++;
                }
            }

            Console.WriteLine("The prime you are looking for is " + nthprime);
            Console.Read();
        }


        static bool findprime(int testprime)
        {
            int testlimit = (int)Math.Sqrt(testprime);
            for (int i = 2; i <= testlimit; i++)
            {
                if (testprime % i == 0)
                {
                    return false;
                }

            }
            return true;
        }

    }
}
