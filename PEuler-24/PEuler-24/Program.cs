using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // lexicographic permutations

            // !n is the formula for the number of permuations for n different items
            // so !10 = 3,628,800 different permuations with 10 unique numbers, 0 - 9
            // looking for the 1,000,000 permuation

            double permutation = 999999;
            double realanswer = translateanswer(calcdiff(permutation));

            //tests all possible values
            /*double test = 0123456789;
            for (double i = 0; i < 3500000; i++ )
            {
                Console.WriteLine("Testing " + i);
                double testanswer = translateanswer(calcdiff(i));
                if (testanswer < test) Console.WriteLine("problem at " + i);
                test = testanswer;
            }
            double realanswer = 9;
            */

                Console.WriteLine("the digits occur at " + realanswer);
            Console.Read();
        }

        static double calcdiff(double permutation)
        {
            // the first digit of the permuation switches every 9! = 362,880 digits
            double answer = Math.Floor(permutation / 362880) * 100000000;
            permutation = permutation % 362880;

            // the second digit occurs every 8! = 40,320
            answer += Math.Floor(permutation / 40320) * 10000000;
            permutation = permutation % 40320;

            // third digit occurs every 7! = 5040
            answer += Math.Floor(permutation / 5040) * 1000000;
            permutation = permutation % 5040;

            // fourth digit occurs every 6! = 720
            answer += Math.Floor(permutation / 720) * 100000;
            permutation = permutation % 720;

            //fifth digit occurs every 5! = 120
            answer += Math.Floor(permutation / 120) * 10000;
            permutation = permutation % 120;

            // sixth digit occurs every 4! = 24
            answer += Math.Floor(permutation / 24) * 1000;
            permutation = permutation % 24;

            // seventh digit occurs every 3! = 6
            answer += Math.Floor(permutation / 6) * 100;
            permutation = permutation % 6;

            // eighth digit occurs every 2! = 2
            answer += Math.Floor(permutation / 2) * 10;
            permutation = permutation % 2;

            // ninth digit occurs every 1! = 1
            answer += Math.Floor(permutation / 1) * 1;
            permutation = permutation % 1;

            //10th digit must be 0;
            answer += 0;


            return answer;
        }

        static double translateanswer(double answer)
        {
            List<int> numlist = new List<int>();
            for (int i = 0; i < 10; i++) numlist.Add(i);

            double realanswer = 0;
            for (int i = 0; i < 10; i++)
            {
                int tmp = (int)(answer / Math.Pow(10, 8 - i));
                realanswer += (numlist[tmp] * Math.Pow(10, 9-i));
                numlist.RemoveAt(tmp);
                answer -= (tmp * Math.Pow(10, 8 - i));
            }


            return realanswer;
        }
    }
}
