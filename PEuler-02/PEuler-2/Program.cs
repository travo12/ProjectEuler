using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int evencount = 0;
            int firstnum = 2;
            int secondnum = 1;

            while (firstnum < 4000000)
            {
                if (firstnum % 2 == 0)
                {
                    evencount += firstnum;
                }
                int temp = firstnum;
                firstnum = firstnum + secondnum;
                secondnum = temp;
            }

            Console.WriteLine("The answer is " + evencount);
            Console.Read();
        }
    }
}
