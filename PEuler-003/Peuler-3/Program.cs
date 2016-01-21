using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peuler_3
{
    class Program
    {
        static void Main(string[] args)
        {

            long testnum = (long)600851475143;
            //take sqrt of test number as a max number to test.
            int test = (int)Math.Sqrt(testnum);

            //gather list of eligible primes 
            List<int> primenums = gatherprimes(test);
            int answer = 0;
            
            //check if they are divisible by the test number. 
            foreach (int i in primenums)
            {
                if (testnum % i == 0)
                {
                    Console.WriteLine("A Prime Factor is " + i);
                    answer = i;
                }
            }

            Console.WriteLine("There are " + primenums.Count + " eligible primes");
            Console.WriteLine("the answer is " + answer);
            Console.Read();

        }
        //Populate the list with prime numbers upto sqrt(maxnum)
        static List<int> gatherprimes(int maxnum)
        {
            List<int> Primes = new List<int>();
            Primes.Add(2);
            
            //start at 3, go by incriments of 2 beause even numbers cant be prime
            for (int count = 3; count <= maxnum; count += 2 )
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
            for (int i = 2; i < testlimit; i++)
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
