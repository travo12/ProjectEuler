using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler_19
{
    class Program
    {
        static void Main(string[] args)
        {
            // counting sundays at first of month

            // set up LL
            LLmonths months = new LLmonths();
            months.buildyear();

            //because we start on monday, we will use monday as the start of the week
            //so sunday will be == 7
            int sundaycount = 0;
            int currentday = 1;
            while (months.year <= 2000)
            {
                Console.WriteLine("The current year is " + months.year);
                for(int j = 1; j <= 12; j++)
                {   
                    // 1900 is NOT a leap year
                    if (months.year == 1900) currentday = (months.currentmonth.days+currentday) % 7;
                    // Everything else divisible by 4 is a leap year on february
                    else if ((months.currentmonth.Month == "February") && ((months.year % 4) == 0))
                    {
                        currentday = (months.currentmonth.days + currentday + 1) % 7;
                        Console.WriteLine("leap year at " + months.year);
                    }
                    //find the day of the week for the start of the next month
                    else currentday = (months.currentmonth.days + currentday) % 7;
                    // start at 1901 because of stupid wording
                    if ((currentday == 0)  && (months.year >= 1901)) sundaycount++;
                    months.currentmonth = months.currentmonth.nextnode;
                }
                months.year++;
            }

            Console.WriteLine("The Number of times sunday appears is " + sundaycount);
            Console.Read();
        }
    }

    public class LLmonths
    {
        public Node currentmonth { get; set; }
        public int year { get; set; }

        public void buildyear()
        {
            year = 1900;

            Node JanNode = new Node { Month = "January", days = 31 };
            Node FebNode = new Node { Month = "February", days = 28 };
            JanNode.nextnode = FebNode;
            Node MarNode = new Node { Month = "March", days = 31 };
            FebNode.nextnode = MarNode;
            Node AprNode = new Node { Month = "April", days = 30 };
            MarNode.nextnode = AprNode;
            Node MayNode = new Node { Month = "May", days = 31 };
            AprNode.nextnode = MayNode;
            Node JuneNode = new Node { Month = "June", days = 30 };
            MayNode.nextnode = JuneNode;
            Node JulNode = new Node { Month = "July", days = 31 };
            JuneNode.nextnode = JulNode;
            Node AugNode = new Node { Month = "August", days = 31 };
            JulNode.nextnode = AugNode;
            Node SeptNode = new Node { Month = "September", days = 30 };
            AugNode.nextnode = SeptNode;
            Node OctNode = new Node { Month = "October", days = 31 };
            SeptNode.nextnode = OctNode;
            Node NovNode = new Node { Month = "Noveber", days = 30 };
            OctNode.nextnode = NovNode;
            Node DecNode = new Node { Month = "December", days = 31 };
            NovNode.nextnode = DecNode;
            DecNode.nextnode = JanNode;

            currentmonth = JanNode;
        }
    }

    public class Node
    {
        public Node nextnode { get; set; }
        public int days { get; set; }
        public string Month { get; set; }
    }
}
