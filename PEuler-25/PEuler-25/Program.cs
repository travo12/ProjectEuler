using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_25
{
    class Program
    {
        static void Main(string[] args)
        {
            // find index of 1000 digit fibonacci number
            // cannot use int or double, must make my own adder

            //using list<int> to add. cheating and starting with initial values
            List<int> CurrentNumber = new List<int>();
            List<int> LastNumber = new List<int>();
            CurrentNumber.Add(1);
            LastNumber.Add(1);
            int fibindex = 2;
            
            while (CurrentNumber.Count < 1000)
            {
                List<int> TmpNumber = new List<int>();
                // must add in this way sadly. Setting it equal will fk things up
                foreach (int i in CurrentNumber) TmpNumber.Add(i);
                ListAdd(ref CurrentNumber, ref LastNumber);
                fibindex++;
                Console.WriteLine("currently at " + fibindex);
                LastNumber = TmpNumber;
            }

            Console.WriteLine("The first index with "+CurrentNumber.Count+" digits is "+fibindex);
            Console.Read();
        }

        static void ListAdd(ref List<int> CurrentNumber, ref List<int> LastNumber)
        {
            int Carry = 0;
            // must use lastnumber's count to make sure we dont go out of bounds
            for (int i = 0; i < LastNumber.Count; i++)
            {
                CurrentNumber[i] += LastNumber[i] + Carry;

                if (CurrentNumber[i] > 9)
                {
                    Carry = 1;
                    CurrentNumber[i] -= 10;
                }
                else Carry = 0;
            }
            // this is to deal with a remaining carry, keeping in mind we never dealt with the final digit of CurrentNumber
            if (Carry == 1)
            {
                //if we never got to last digit of CurrentNumber
                if (CurrentNumber.Count > LastNumber.Count)
                {
                    if (CurrentNumber[CurrentNumber.Count - 1] == 9) CurrentNumber.Add(1);
                    else CurrentNumber[CurrentNumber.Count - 1]++;
                }
                // if we did get to last digit of CurrentNumber
                else CurrentNumber.Add(1);
            }

        }

    }
}