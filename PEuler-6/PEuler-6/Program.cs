using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // find sum of squares
            double sumsquare = 0;
            for (int i = 1; i <= 100; i++) sumsquare += Math.Pow(i, 2);
     

            //find square of sum
            double squaresum = 0;
            for (int i = 1; i <= 100; i++) squaresum += i;
            squaresum = Math.Pow(squaresum, 2);
           
            //calc answer and output
            double answer = squaresum - sumsquare;
            Console.WriteLine("The Answer is " + answer);
            Console.Read();



        }
    }
}
