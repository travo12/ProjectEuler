using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEuler_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer = getcount("C:/data/PEuler13.txt");


            //prints exponential notation, can just type out first 10 digits that appear
            Console.WriteLine("The answer is " + answer);
            Console.Read();

        }

        //inputs from file, adds lines together
        static double getcount(string filename)
        {
            StreamReader reader = new StreamReader(filename);
            double totalcount = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                totalcount += (Convert.ToDouble(line.ToString()));
                line = reader.ReadLine();
            }
            return totalcount;
        }

    }
}
