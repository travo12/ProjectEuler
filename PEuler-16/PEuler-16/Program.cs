using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double doesthiswork = Math.Pow(2, 1000);
            Console.WriteLine("2^1000 is " + doesthiswork);
            
            //302 digits in the answer

            int multnumber = 1000;
            int[] numarray = new int[302];

            // set starting value
            numarray[0] = 1;

            //set rest of values to 0
            for (int i = 1; i < numarray.Length; i++) numarray[i] = 0;

            // start doubling
            for (int i = 0; i < multnumber; i++) doublearray(ref numarray);
          
            double arraysum = 0;
            for (int i = 0; i < numarray.Length; i++) arraysum += numarray[i];


            Console.WriteLine("The sum of the number is " + arraysum);
            Console.Read();

        }
        // double value of array
        static void doublearray(ref int[] numarray)
        {
            int carryover = 0;
            for (int i = 0; i < numarray.Length; i++)
            {
                numarray[i] *= 2;
                numarray[i] += carryover;
                carryover = 0;

                if (numarray[i] >= 10)
                {
                    carryover = 1;
                    numarray[i] -= 10;
                }
            }
        }
    }
}
