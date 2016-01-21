using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PEuler_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //get file input, put into sorted list
            string file = "C:/Users/Trav/Desktop/Projects/Project Euler/PEuler-22/PEuler-22/p022_names.txt";
            List<string> sortedNames = new List<string>();
            GatherSort(ref sortedNames, file);

            //calculate function for each value
            int answer = 0;
            for (int i = 0; i < sortedNames.Count; i++)
            {
                answer += (1 + i) * AlphaCount(sortedNames[i].ToLower());
                Console.WriteLine(sortedNames[i] + " is adding " + (1 + i + AlphaCount(sortedNames[i].ToLower())));
            }

            Console.WriteLine("the answer is " + answer);
            Console.Read();
        }

        public static void GatherSort(ref List<string> SortedNames, string file)
        {
            // only 1 line in file
            StreamReader reader = new StreamReader(file);
            String tonsofnames = reader.ReadLine();
            // splits names by value of comma
            string[] names = tonsofnames.Split(',');

            // remove quotation marks and sort
            foreach (string s in names)
            {
                string tmp = s.Trim('\"');
                tmp = tmp.ToString();
                //alphabetically insert into SortedNames
                SortedNames.Insert(GetAlphaIndex(ref SortedNames, tmp), tmp);
            }
        }

        // returns index of List to alphabetically sort
        public static int GetAlphaIndex(ref List<string> SortedNames, string tmp)
        {
            if (SortedNames.Count == 0)  return 0;
            int position = 0;
            for (int i = 0; i < SortedNames.Count; i++)
            {
                int comp = String.Compare(SortedNames[i], tmp, true);
                if (comp > 0) return position;
                else if (comp == 0) return i;
                else position++;
            }
            return position;
        }

        // returns alphabetical value of a string
        public static int AlphaCount(String Name)
        {
            int count = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                switch (Name[i])
                {
                    case 'a': count += 1; break;
                    case 'b': count += 2; break;
                    case 'c': count += 3; break;
                    case 'd': count += 4; break;
                    case 'e': count += 5; break;
                    case 'f': count += 6; break;
                    case 'g': count += 7; break;
                    case 'h': count += 8; break;
                    case 'i': count += 9; break;
                    case 'j': count += 10; break;
                    case 'k': count += 11; break;
                    case 'l': count += 12; break;
                    case 'm': count += 13; break;
                    case 'n': count += 14; break;
                    case 'o': count += 15; break;
                    case 'p': count += 16; break;
                    case 'q': count += 17; break;
                    case 'r': count += 18; break;
                    case 's': count += 19; break;
                    case 't': count += 20; break;
                    case 'u': count += 21; break;
                    case 'v': count += 22; break;
                    case 'w': count += 23; break;
                    case 'x': count += 24; break;
                    case 'y': count += 25; break;
                    case 'z': count += 26; break;

                }
            }
            return count;
        }
    }
}
