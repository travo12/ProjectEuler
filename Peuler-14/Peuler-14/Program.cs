using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peuler_14
{
    class Program
    {

        static void Main(string[] args)
        {
            // brute force
            int highcount = 0;
            int longestchain = 0;
            for(int i = 13; i<=1000000;i++)
            {
                int sequencecount = 0;
                double seqnum = (double)i;

                while (seqnum != 1)
                {
                    if (seqnum % 2 == 0) // if even
                    {
                        seqnum /= 2;
                        sequencecount++;
                    }
                    else
                    {
                        seqnum = (3 * seqnum) + 1;
                        sequencecount++;
                    }
                }
                if (sequencecount > highcount)
                {
                    highcount = sequencecount;
                    longestchain = i;
                    Console.WriteLine("New longest chain at number " + longestchain + " with " + highcount + " chains!");
                }
            }

            Console.WriteLine("The Longest Chain is " + highcount);
            Console.WriteLine("The number is " + longestchain);
            Console.Read();
        }
    }
}
