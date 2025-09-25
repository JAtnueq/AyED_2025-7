using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_13_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan dos vectores de N componentes enteras. La computadora los suma y
              muestra el vector resultante.*/
            int n = 0;
            Console.WriteLine("--- Tamaño Vector ---");
            Console.WriteLine("¿De cuantos elementos seran los vectores?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- Llenar el vector 1 ---");
            //--------------------------
            int[] vector_a = new int[n];
            int[] vector_b = new int[n];
            //--------------------------
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduce el elemento numero {0}°", i);
                vector_a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("--- Llenar el vector 2 ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduce el elemento numero {0}°", i);
                vector_b[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] vector_suma = new int[n];
            for (int i = 0; i < n; i++)
            {
                vector_suma[i] = vector_a[i] + vector_b[i];
                Console.Write("Vector A;Elemento {0}° =", i); Console.Write(vector_a[i]); Console.Write(" + ");
                Console.Write("Vector B;Elemento {0}° =", i); Console.Write(vector_b[i]); Console.Write(" = "); Console.WriteLine(vector_suma[i]);
            }
            Console.WriteLine("--- Vector AB ---");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Vector AB; Elemento {0}° = ", i); Console.WriteLine(vector_suma[i]);
            }
            Console.ReadKey();
        }
    }
}
