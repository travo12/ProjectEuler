using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primes = gatherprimes(2000000);

            double count = 0;

            foreach (int i in Primes)  count += i;

            Console.WriteLine("The sum of all primes below 2mil is " + count);
            Console.Read();

        }

        static List<int> gatherprimes(int maxnum)
        {
            List<int> Primes = new List<int>();
            Primes.Add(2);

            //start at 3, go by incriments of 2 beause even numbers cant be prime
            for (int count = 3; count <= maxnum; count += 2)
            {
                if (findprime(count))
                {
                    Primes.Add(count);
                }
            }
            return Primes;
        }

        //figures out if a number is prime or not
        //returns true if prime
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
