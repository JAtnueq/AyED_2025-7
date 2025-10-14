﻿using System;
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
            /*Se ingresa una matriz de NxM componentes. La computadora indica la cantidad
              de ceros que contiene.*/
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
            int cont = 0;
            for (int x = 0; x < n; x++)
            {
                for (int y = 0; y < m; y++)
                {
                    if (matriz[x,y] == 0)
                    {
                        cont += 1; 
                    }
                }
            }
            Console.WriteLine("Cantidad de ceros en la matriz: " + cont);
            Console.ReadKey();
        }
    }
}