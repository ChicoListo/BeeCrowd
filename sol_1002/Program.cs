using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            double r = double.Parse(line);
            double pi = 3.14159;
            double A = pi * Math.Pow(r, 2);

            Console.WriteLine($"A={A.ToString("F4")}");
        }
    }
}
