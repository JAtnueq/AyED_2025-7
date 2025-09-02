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
            /*Imprimir y sumar los elementos que ocupan las posiciones pares de una lista
              numérica.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i +1 );
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0;
            Console.WriteLine("--- Elementos en posiciones pares: ---");

            for (int i = 0; i < capacidad; i++)
            {
                if (i % 2 == 0) // si el índice es par
                {
                    Console.WriteLine("Posición {0}: {1}", i +1 , numero[i]);
                    suma += numero[i];
                }
            }

            Console.WriteLine("La suma de los elementos en posiciones pares es: {0}", suma);

            Console.ReadKey();
        }
    }
}