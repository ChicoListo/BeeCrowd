using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            line = Console.ReadLine();
            b = int.Parse(line);
            line = Console.ReadLine();
            c = int.Parse(line);
            line = Console.ReadLine();
            d = int.Parse(line);
            Console.WriteLine($"DIFERENCIA = {((a * b) - (c * d))}");
        }
    }
}
