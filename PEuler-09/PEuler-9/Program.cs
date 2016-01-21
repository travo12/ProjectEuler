using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // try #1, brute force

            for (int i = 1; i < 1000; i++)
            {
                for (int j = i + 1; j < 1000; j++)
                {
                    // Substituted C in the equation a+b+c = 1000
                    double testme = i + j + Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                    if (testme == 1000) 
                    {
                        double c = Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                        Console.WriteLine("possible values are");
                        Console.WriteLine("a = " + i);
                        Console.WriteLine("b = " + j);
                        Console.WriteLine("c = " + c);
                        Console.WriteLine("The Answer should be " + (i * j * c));
                    }
                }
            }
            Console.WriteLine("Program is finished!");
            Console.Read();
        }
    }
}
