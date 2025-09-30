using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_15_vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cargar un array de m números enteros decir cual es el mayor y donde
              esta.*/
            int n = 0;
            Console.WriteLine("--- Tamaño Vector ---");
            Console.WriteLine("¿De cuantos elementos seran el vector?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("--- Llenar el vector ---");
            //--------------------------
            int[] vector = new int[n];
            //--------------------------
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Introduce el elemento numero {0}°", i);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }
            //-------------
            int mayor = 0;
            int guardar_pos = 0;
            //-------------
            for (int i = 0; i < n; i++)
            {
                if (vector[i] >= mayor)
                {
                    mayor = vector[i];
                    guardar_pos = i;
                }
            }
            Console.WriteLine("----- Mayor valor del vector -----");
            Console.Write("Elemento {0}°", guardar_pos); Console.Write(" = " + mayor);
            Console.ReadKey();
            /*
         ------- Como declarar ArraysList´s----------
             * ArrayList datos = new ArrayList()
         ------- Añadir elementos a un array list ------
             *datos = add(8)
           *Si queremos que el usuario añada sus datos
             *datos = add(n)
             *n= 8 //n es declaradado anteriormente por el usuario     
             */
        }
