using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // max to check is sqrt(num)

            //made almost everything double type cause numbers get huge
            int divisornumber = 501;

            double answer = findnumber(divisornumber);


            Console.WriteLine("The Number is " +answer);
            Console.Read();
        }

        static double findnumber(int divisornumber)
        {
            double trinumber = 0;
            double count = 0;
            while(true)
            {
                trinumber += count;
                int trianglecount = 0;
                for (int i = 1; i <= Math.Sqrt(trinumber); i++ )
                {
                    if (trinumber % i == 0)
                    {
                        // must check if sqrt is natural number
                        if (trinumber / i == i) { trianglecount++; }
                        else { trianglecount += 2; }
                    }
                    
                }
                if (trianglecount >= divisornumber)
                {
                    return trinumber;
                }

                    count++;
            }

            
        }
    }
}
