using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_10_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 enteros. La computadora muestra aquellos ingresados con
              número de orden impar.*/
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
                if (numero[i] % 2 != 0) // si el índice es impar
                {
                    Console.WriteLine("Posición {0}: {1}", i, numero[i]);
                    //Imprime "Posicion" y luego reemplaza el {0} y el {1}
                }
            }
            Console.ReadKey();
        }
    }
}
