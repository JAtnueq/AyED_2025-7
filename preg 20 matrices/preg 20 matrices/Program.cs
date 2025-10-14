using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_20_matrices
{
    class funciones
    {
        public void traza_matriz(ref int[,] matriz, ref int n)
        {
            //Birdbrain y Liar Dancer son vida :Vv
            int suma = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (x == y)
                    {
                        suma += matriz[x, y];
                    }
                }
            }
            Console.WriteLine("Suma de la diagonal principal de la matriz: " + suma);
        }
        public void diagonal_secundaria(ref int[,] matriz,ref int n)
        {
            //Birdbrain Y Liar Dancer son vida
            int suma = 0;
            int x = (n - 1);
            int y = 0;
            for (int i = (n-1); i >= 0; i--)
            {
                suma += matriz[x, y];
                x -= 1;
                y += 1;
            }
            Console.WriteLine("Suma de la diagonal secundaria de la matriz: " + suma);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Se ingresa una matriz de NxN componentes. La computadora calcula y muestra:
               a) La traza de la matriz (suma de los elementos de la diagonal principal)
               b) La suma de los elementos de la otra diagonal*/
            int n = 0;
            Console.WriteLine("--- Tamaño Vector ---");
            Console.WriteLine("¿De cuantos elementos sera el vector?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- Llenar el vector ---");
            //--------------------------
            int[,] matriz = new int[n, n];
            //--------------------------
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    Console.WriteLine("Introduce el elemento numero [{0},{1}]", x, y);
                    matriz[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            funciones f = new funciones();
            f.traza_matriz(ref matriz, ref n);
            Console.WriteLine("--------------------------------------");
            f.diagonal_secundaria(ref matriz, ref n);
            Console.ReadLine();
        }
    }
}
