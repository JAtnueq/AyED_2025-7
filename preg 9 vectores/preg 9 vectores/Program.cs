using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 enteros. La computadora muestra, a continuación, 
              aquellos que son pares.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--- Elementos pares: ---");

            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] % 2 == 0) // si el índice es par
                {
                    Console.WriteLine("Posición {0}: {1}", i, numero[i]);
                }
            }
            Console.ReadKey();
        }
    }
}