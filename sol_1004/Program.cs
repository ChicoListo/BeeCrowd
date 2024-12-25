using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            b = int.Parse(line);
            Console.WriteLine($"PROD = {a*b}");
        }
    }
}
