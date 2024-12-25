using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            string line;
            line = Console.ReadLine();
            a = double.Parse(line);
            line = Console.ReadLine();
            b = double.Parse(line);
            line = Console.ReadLine();
            c = double.Parse(line);
            Console.WriteLine($"MEDIA = {((2.0 / 10.0 * a) +(3.0/10.0 * b)+ (5.0/10.0*c)).ToString("F1")}");
        }
    }
}
