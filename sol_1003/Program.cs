using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string line;
            line = Console.ReadLine();
            a = int.Parse(line);
            line = Console.ReadLine();
            b = int.Parse(line);
            Console.WriteLine($"SOMA = {a + b}");
        }
    }
}
