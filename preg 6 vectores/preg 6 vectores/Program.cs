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
            /*Visualizar, contar y sumar los elementos pares que ocupan las posiciones
              impares de lista anterior. Imprimir las posiciones que ocupan dichos elementos
              en la lista.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            int suma = 0;
            Console.WriteLine("--- Elementos en posiciones impares: ---");

            for (int i = 0; i < capacidad; i++)
            {
                if (i % 2 != 0) // si el índice es impar
                {
                    if (numero[i] % 2 == 0)
                    {
                        Console.WriteLine("Posición {0}: {1}", i, numero[i]);
                        suma += numero[i];
                    }
                }
            }

            Console.WriteLine("La suma de los elementos pares en posiciones impares es: {0}", suma);

            Console.ReadKey();
        }
    }
}
