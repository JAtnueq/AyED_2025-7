using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_20_matrices
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Se ingresa una matriz de NxM componentes. La computadora muestra:

              a) el promedio de la matriz
              b) el promedio de cada fila
              c) el promedio de cada columna
              
            */
            int n = 0;
            int m = 0;
            Console.WriteLine("--- Tamaño Vector ---");
            Console.WriteLine("Asignar valores para las dimensiones de la matriz");
            Console.WriteLine("- - -   N x M   - - -");
            Console.WriteLine("¿De cuantos sera N?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿De cuantos sera M?");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- Llenar el vector ---");
            //--------------------------
            int[,] matriz = new int[n, m];
            //--------------------------
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    Console.WriteLine("Introduce el elemento numero [{0},{1}]", x, y);
                    matriz[x, y] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //---------- Promedio de la matriz------------------------------
            int pasajero = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    pasajero += matriz[n, m];
                }
            }
            int promedio = (pasajero)/ (n * m);
            //--------------------------------------------------------------
            //---------- Promedio de la fila------------------------------
            int otropasajero = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    otropasajero += matriz[n, m];
                }
            }
            int promedio_fila = (otropasajero) / (n * m);
            //--------------------------------------------------------------
            Console.WriteLine("Promedio de la matriz: " + promedio);
            Console.ReadKey();
        }
    }
}