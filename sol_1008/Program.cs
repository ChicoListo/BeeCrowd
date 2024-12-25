using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nume;
            double pagoh, horas;
            string line;
            line = Console.ReadLine();
            nume = int.Parse(line);
            line = Console.ReadLine();
            horas = double.Parse(line);
            line = Console.ReadLine();
            pagoh = double.Parse(line);
            Console.WriteLine($"NUMBER = {nume}");
            Console.WriteLine($"SALARY = U$ {(horas * pagoh).ToString("F2")}");

        }
    }
}
