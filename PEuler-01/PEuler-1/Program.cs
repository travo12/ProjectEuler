using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("count is at " + count);
       
            for (int i = 3; i<1000; i++)
            {
                if ((i % 3 == 0) | (i % 5 == 0))
                {
                    Console.WriteLine("i % 3 is " + i % 3);
                    Console.WriteLine("i % 5 is " + i % 5);
                    count += i;
                }
            }
                Console.WriteLine("The Answer is " + count);

            Console.Read();

        }
    }
}
