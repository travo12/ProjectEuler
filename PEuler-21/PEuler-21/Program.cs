using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_21
{
    class Program
    {
        static void Main(string[] args)
        {
            // brute force
    	    List<int> AmicableNumbers = new List<int>();	

	        for (int i = 2; i <= 10000; i++)
	        {
		        //make sure its not a duplicate
		        if (!AmicableNumbers.Contains(i)) 
		        {
			        // get sum of divisors
			        int amicable = Divisorsum(i);
			        // check to see if amicable
                    if (amicable <= 10000)
                    {
                        if (Divisorsum(amicable) == i)
                        {
                            if (i  != amicable)
                            {
                                AmicableNumbers.Add(i);
                                AmicableNumbers.Add(amicable);
                            }
                        }
                    }
		        }
	        }
	        // add all the amicable numbers
	        int AmicableTotal = 0;
            foreach (int i in AmicableNumbers) AmicableTotal += i;

            Console.WriteLine("The Sum of the AmicableNumbers is " + AmicableTotal);
    	    Console.Read();
        }

        public static int Divisorsum(int number)
        {
	        List<int> divisors = new List<int>();
            //1 is a divisor, but the number itself is not. IDK.
            divisors.Add(1);
            for (int j = 2; j <= (int)Math.Sqrt(number); j++)
            {
                if (number % j == 0)
                {
                    divisors.Add(j);
                    //dont add proper square roots twice
                    if (number / j != (int)Math.Sqrt(number)) divisors.Add((int)(number / j));
                }
            }
	     
	        //add the divisors
	        int divisorsum = 0;
	        foreach (int i in divisors) divisorsum += i;

	        return divisorsum;
        }
		 
    }
}
