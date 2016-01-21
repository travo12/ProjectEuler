using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_15
{

    class Program
    {


        static void Main(string[] args)
        {
            int size = 21;

            double[,] pointarray = new double[size, size];

            for (int i = 0; i < size;i++ )
            {
                pointarray[i, 0] = 1;
                pointarray[0, i] = 1;
            }

            for (int i = 1; i < size-1; i++)
            {
                for (int j = 1; j< size; j++)
                {
                    pointarray[i, j] = pointarray[i - 1, j] + pointarray[i, j - 1];
                }
            }


                Console.WriteLine("# of ways to traverse is " + (pointarray[size-2,size-1]*2));
            Console.Read();

        }

    }
}
