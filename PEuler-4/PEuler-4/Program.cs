using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the largest palendrome
            int checknum = 0;
            //start checkin!
            for (int i = 999; i >= 100; i--)
            {
                // j=i because all numbers above i have been checked
                for (int j = i;  j >= 100; j--)
                {
                    if (ispalandrome(i * j))
                    {
                        //Console.WriteLine("The following is a palandrome " + i * j);
                        //keep track of highest current palandrome
                        if (i * j > checknum) checknum = i * j;
                    }
                }
            }
            Console.WriteLine("Done!");
            Console.Read();
       }

        
        static bool ispalandrome (int checkpalandrome)
        {
            string palandromecheck = checkpalandrome.ToString();

            //length / 2 ignores the middle character if length is odd
            for (int i = 1; i <= palandromecheck.Length / 2; i++ )
            {
                if (palandromecheck[i - 1] != palandromecheck[palandromecheck.Length - i]) return false;
            }

            return true;
        }
    }
}
