using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 números. La computadora muestra aquellos
             que son múltiplos del último número ingresado.*/
            int temp;
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i + 1);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = capacidad-1; i >= 0; i--)
            {
                int posible;
                posible = numero[i] % numero[9];
                if (posible == 0)
                {
                    Console.WriteLine("El dato numero {0}", (i+1) + " es multiplo");
                }
                if (posible != 0)
                {
                    Console.WriteLine("El dato numero {0}", (i+1) +" no es multiplo");
                }
            }
            Console.ReadKey();
        }
    }
}
