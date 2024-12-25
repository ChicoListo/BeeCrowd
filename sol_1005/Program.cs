using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string line;
            line = Console.ReadLine();
            a = double.Parse(line);
            line = Console.ReadLine() ;
            b = double.Parse(line);
            Console.WriteLine($"MEDIA = {((3.5 / 11.0 * a) + (7.5 / 11.0 * b)).ToString("F5")}");

        }
    }
}
