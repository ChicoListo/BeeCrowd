using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string[] roadsandnume = Console.ReadLine().Split(' ');

                int roads = int.Parse(roadsandnume[0]);
                int nume = int.Parse(roadsandnume[1]);

                if (roads == 0 && nume == 0)
                {
                    Console.WriteLine(' ');

                    break;
                 
                }

                if (nume * (26 + 1) < roads)
                {
                    Console.WriteLine("Case 2: Impossible");
                }
                else if( nume >= roads)
                {
                    int  remainingRoads = (roads - nume), suffixes = ((remainingRoads + nume - 1)/nume);

                    Console.WriteLine($"Case 1: {suffixes}");
                }
                Console.ReadKey();

            }
        }
    }
}
