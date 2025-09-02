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
            /*Se ingresan 10 números. La computadora los muestra en el orden inverso del
              que tenían al ser ingresados.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i + 1);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = capacidad - 1; i >= 0; i--)
            {
                Console.Write("Celda numero {0}", i +1);
                Console.WriteLine(" = " + numero[i]);
            }
            Console.ReadKey();
        }
    }
}