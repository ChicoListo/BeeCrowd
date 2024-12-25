using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sol_1449
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lee el número de instancias (casos de prueba)
            int T = int.Parse(Console.ReadLine());

            // Itera a través de cada instancia
            for (int i = 0; i < T; i++)
            {
                // Lee la línea que contiene el número de palabras en el diccionario (M) y el número de líneas en la canción (N)
                string[] line = Console.ReadLine().Split(' ');
                int M = int.Parse(line[0]);
                int N = int.Parse(line[1]);

                // Crea un diccionario para almacenar las traducciones (palabra japonesa -> traducción portuguesa)
                Dictionary<string, string> traducciones = new Dictionary<string, string>();

                // Lee las M traducciones y las agrega al diccionario
                for (int j = 0; j < M; j++) 
                {
                    string palabraJaponesa = Console.ReadLine();
                    string traduccionPortuguesa = Console.ReadLine();
                    traducciones.Add(palabraJaponesa, traduccionPortuguesa);
                }

                // Lee y traduce las N líneas de la canción
                for (int k = 0; k < N; k++) 
                {
                    string lineaCancion = Console.ReadLine(); // Lee una línea de la canción
                    string[] palabras = lineaCancion.Split(' '); // Divide la línea en palabras separadas por espacios
                    string lineaTraducida = ""; // Inicializa la línea traducida

                    // Recorre cada palabra de la línea
                    foreach (string palabra in palabras)
                    {
                        // Si la palabra está en el diccionario, agrega su traducción a la línea traducida
                        if (traducciones.ContainsKey(palabra))
                        {
                            lineaTraducida += traducciones[palabra] + " ";
                        }
                        // Si no está en el diccionario, agrega la palabra original a la línea traducida
                        else
                        {
                            lineaTraducida += palabra + " ";
                        }
                    }

                    // Imprime la línea traducida (sin el espacio final)
                    Console.WriteLine(lineaTraducida.TrimEnd());
                    Console.WriteLine(); // Imprime una línea en blanco después de cada línea traducida
                }
            }

            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}