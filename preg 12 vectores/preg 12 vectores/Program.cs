using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_12_vectores
{
    class Funciones
    {
        public int capacidad = 10;
        public int[] numero;
        public void datos()
        {
            
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void mayor()
        {
            int mayor = 0;
            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] > mayor)
                {
                    mayor = numero[i];
                }
            }
            Console.WriteLine("El elemento con mayor valor del vector es:");
        }
        public void medio()
        {
            int promedio;
            for (int i = 0; i < capacidad; i++)
            {
                
            }
            Console.WriteLine("El elemento con mayor valor del vector es:");
        }
        public void menor()
        {
            int menor = 0;
            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] > menor)
                {
                    menor = numero[i];
                }
            }
            Console.WriteLine("El elemento con mayor valor del vector es:");
        }
        public void positivos()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir funciones que reciban un arreglo de 10 números enteros y devuelvan el
              mayor valor, el menor valor, el valor medio y la suma de todos los valores
              positivos.*/
            

        }
    }
}
