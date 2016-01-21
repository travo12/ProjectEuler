using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //calculate 100!
            int factquestion = 100;
            //double answer = factorial(factquestion);

            List<int> anslist = new List<int>();
            //fill the array max size 159
            anslist.Add(1);
            for (int i = 0; i < 158; i++) anslist.Add(0);

            

            calcfactorial(ref anslist, factquestion);

            int realanswer = 0;
            foreach (int j in anslist) realanswer += j;

            Console.WriteLine("the answer is " + realanswer);
            Console.Read();
        }
        static void calcfactorial (ref List<int> anslist, int factnum)
        {
            int carryover = 0;
            for (int i = 1; i <= factnum; i++)
            {
                for (int j = 0; j < anslist.Count; j++)
                {
                    anslist[j] *= i;
                    anslist[j] += carryover;
                    // get carryover
                    if (anslist[j] > 9)
                    {
                        int tmp = anslist[j];
                        anslist[j] = anslist[j] % 10;

                        carryover = (tmp - anslist[j]) / 10;
                    }
                    else carryover = 0;
                }
            }
        }
        // used to find the number of digits needed
        static double factorial (int number)
        {
            double calc = 1;
            for (int i = 1; i <= 100; i++)
            {
                calc = calc * i;
            }
            return calc;
        }
    }
}
