using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peuler_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberlist = new List<int>();
            getnumbers(ref numberlist, "C:/data/numberlist.txt");
            Console.WriteLine("#485 " + numberlist[485]);
            int adjacent = 13;
            long highest = 0;
            long currentcount;
            for (int i = 0; i <= numberlist.Count - adjacent; i++ )
            {
                currentcount = 1;
                for (int j = 0; j<adjacent; j++)
                {
                    //Console.WriteLine("its happening to " + numberlist[i]);
                    currentcount *= numberlist[i+j];
                    //Console.WriteLine("its happening to " + numberlist[i]);
                }
                if (currentcount > highest) highest = currentcount;
               // Console.WriteLine("The Greatest Product is " + highest);
                
            }


            Console.WriteLine("The Greatest Product is " + highest);


                Console.Read();
        }


        // get numbers from a file
        static void getnumbers (ref List<int> numberlist, string filename)
        {
            StreamReader reader = new StreamReader(filename);

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    return;
                }
              
                for(int i=0;i<line.Length;i++)
                {
                    numberlist.Add(Convert.ToInt32(line[i].ToString())); // dont ask how long this took to figure out
                }

            }
                       
        }

    }
}
