using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_23
{
    class Program
    {
        //This takes too long to truly be an answer.
        // takes roughly 2 minutes to run.
        static void Main(string[] args)
        {
            //don't need to check above 28123
            //build list of abundant numbers 12-28123
            //add 1-23 to list of
            //start checking 25 - 28123
            // 4179871 

            // build list of abundant numbers 12-28123
            List<int> AbundantNumbers = new List<int>();
            for (int i = 12; i <= 28123; i++)
            {
                if (divsum(i) > i)
                {
                    AbundantNumbers.Add(i);
                }
            }

            // removed some lines from when i tried to do this a different way.
            //build list of abundant number sums
            // List<int> AbundantNumberSums = new List<int>();
            //buildsums(ref AbundantNumberSums, ref AbundantNumbers);

            int answer = 276;

            for (int i = 25; i <= 28123; i++)
            {
                if (!issumabundant(i, ref AbundantNumbers)) answer += i;
            }


            Console.WriteLine("The answer is " + answer);
            Console.Read();
        }

        // returns sum of divisors
        static int divsum(int number)
        {
            int sum = 1;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    if (Math.Sqrt(number) == i) sum += i;
                    else
                    {
                        sum += i;
                        sum += (number / i);
                    }
                }
            }
            return sum;
        }

        /* ended up being way too slow
        static void buildsums(ref List<int> AbundantNumberSums, ref List<int> AbundantNumbers)
        {
            for (int i = 0; AbundantNumbers[i] < 28123/2; i++)
            {
                for (int j = i; j <AbundantNumbers.Count; j++)
                {
                    int tmp = AbundantNumbers[i] + AbundantNumbers[j];
                    if (tmp < 28123)
                    {
                        if (!AbundantNumberSums.Contains(tmp))
                        {
                            Console.WriteLine("Adding " + tmp);
                            AbundantNumberSums.Add(tmp);
                        }
                    }
                }
            }
        } */

        // returns true if is a sum of abundant numbers, false if not
        static bool issumabundant(int number, ref List<int> AbundantNumbers)
        {
            for (int i = 0; AbundantNumbers[i] <= number/2; i++)
            {
                for (int j = i; AbundantNumbers[j] <= number - 12 ; j++)
                {
                    if (AbundantNumbers[i] + AbundantNumbers[j] == number) return true;
                }
            }
            return false;
        }
    }
}
