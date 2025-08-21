using System;
using System.Collections.Generic; // Necesario para usar List<int>
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 números. La computadora muestra el valor máximo e indica la
             cantidad de veces que apareció y el número de orden en que fue ingresado.*/

            int capacidad = 5;
            int[] numeros = new int[capacidad];

            // --- PASO 1: Ingresar los 10 números ---
            // Usamos un bucle for tradicional, es más fácil de leer.
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el número de orden {0}:", i + 1);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maximo = numeros[0];
            for (int i = 1; i < capacidad; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }
            int[] posiciones = new int[capacidad];
            int contador = 0;

            for (int i = 0; i < capacidad; i++)
            {
                if (numeros[i] == maximo)
                {
                    posiciones[contador] = i + 1; // Guardamos el número de orden
                    contador += 1;
                }
            }

            Console.WriteLine("\n----- Resultados -----");
            Console.WriteLine("El valor máximo ingresado fue: " + maximo);
            Console.WriteLine("Apareció en las celdas: ");

            // Mostramos solo las posiciones relevantes
            for (int i = 0; i < contador; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write(posiciones[i]);
            }
            Console.ReadKey();
        }
    }
}
