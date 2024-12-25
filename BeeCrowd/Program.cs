using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeCrowd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] line = Console.ReadLine().Split(' ');

            int a, b, c;

            a = int.Parse(line[0]);
            b = int.Parse(line[1]);
            c = int.Parse(line[2]);

            int mayor;

            if (a >= b && a >= c)
            {
                mayor = a;
            }
            else if (b >= a && b >= c)
            {
                mayor = b;
            }
            else
            {
                mayor = c;
            }
            Console.WriteLine($"{mayor} eh o maior");
            Console.ReadKey();
        }
    }
}
