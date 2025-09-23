using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_11_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 enteros. La computadora muestra la suma de los ingresados
              primero y último, del segundo y el penúltimo, y así sucesivamente.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            int y = 9;
            Console.WriteLine("--- Elementos sumados: ---");
            for (int x = 0; x < 5; x++)
            {
                int suma_elementos;
                suma_elementos = numero[x] + numero[y];
                Console.Write("Suma de los elementos {0}° y {1}° =", x, y);
                Console.WriteLine(suma_elementos);
                y -= 1;
            }
            Console.ReadKey();
        }
    }
}
