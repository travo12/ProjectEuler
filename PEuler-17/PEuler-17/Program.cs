using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PEuler_17
{

    public static class Extensions
    { public static int wordcount(this String str) { return str.Length; } }

    public class Program
    {
        static void Main(string[] args)
        {
            int charnum = 0;
            for (int i = 100; i <= 200; i++)
            {
                int tmp = getlettercount(i);
                Console.WriteLine("i = " + i + " amnt = " + tmp);
                charnum += tmp;
    
                //if (i % 100 == 0) Console.Read();
            }


            Console.WriteLine("The Total number of characters is " + charnum);
            Console.Read();
        }

        static int getlettercount(int number)
        {
            int charcount = 0;
            if (number >= 100)
            {
                if (number % 100 != 0) charcount += 3; // and
               
                if (number < 200) // 100-199
                {
                    charcount += 3 + 7;
                    number -= 100;
                }
                else if (number < 300) // 200 - 299
                {
                    charcount += 3 + 7;
                    number -= 200;
                }
                else if (number < 400) //300 - 399
                {
                    charcount += 5 + 7;
                    number -= 300;
                }
                else if (number < 500) //400 - 499
                {
                    charcount += 4 + 7;
                    number -= 400;
                }
                else if (number < 600) //500 - 599
                {
                    charcount += 4 + 7;
                    number -= 500;
                }
                else if (number < 700) //600 - 699
                {
                    charcount += 3 + 7;
                    number -= 600;
                }
                else if (number < 800) //700 - 799
                {
                    charcount += 5 + 7;
                    number -= 700;
                }
                else if (number < 900) //800 - 899
                {
                    charcount += 5 + 7;
                    number -= 800;
                }
                else if (number < 1000) //900 - 999
                {
                    charcount += 4 + 7;
                    number -= 900;
                }
                else if (number == 1000) return 11;
            }
            

            // 99 - 10
            if (number >= 90) // 90-99
            {
                charcount += 6;
                number -= 90;
            }
            else if (number >= 80) // 80-89
            {
                charcount += 6;
                number -= 80;
            }
            else if (number >= 70) // 70-79
            {
                charcount += 7;
                number -= 70;
            }
            else if (number >= 60) // 60-69
            {
                charcount += 5;
                number -= 60;
            }
            else if (number >= 50) // 50-59
            {
                charcount += 5;
                number -= 50;
            }
            else if (number >= 40) // 40-49
            {
                charcount += 5;
                number -= 40;
            }
            else if (number >= 30) // 30-39
            {
                charcount += 6;
                number -= 30;
            }
            else if (number >= 20) // 20-29
            {
                charcount += 6;
                number -= 20;
            }
            
            if (number == 19) return charcount += 8;
            if (number == 18) return charcount += 8;
            if (number == 17) return charcount += 9;
            if (number == 16) return charcount += 7;
            if (number == 15) return charcount += 7;
            if (number == 14) return charcount += 8;
            if (number == 13) return charcount += 8;
            if (number == 12) return charcount += 6;
            if (number == 11) return charcount += 6;
            if (number == 10) return charcount += 3;
            if (number == 9) return charcount += 4;
            if (number == 8) return charcount += 5;
            if (number == 7) return charcount += 5;
            if (number == 6) return charcount += 3;
            if (number == 5) return charcount += 4;
            if (number == 4) return charcount += 4;
            if (number == 3) return charcount += 5;
            if (number == 2) return charcount += 3;
            if (number == 1) return charcount += 3;
            if (number == 0) return charcount;
            


            //something went wrong
            return 1000000;
            
        }
    }


}
