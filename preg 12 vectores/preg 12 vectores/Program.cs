using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_13_vectores
{
    class Funciones
    {
        public int capacidad = 10;
        public void datos()
        {

            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void mayor(ref int []numero)
        {
            int mayor = 0;
            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] >= mayor)
                {
                    mayor = numero[i];
                }
            }
            Console.Write("+++ /// El elemento con mayor valor del vector es:");
            Console.WriteLine(mayor);
        }
        public void medio(ref int[] numero)
        {
            int promedio = 0;
            int numeros = 0;
            for (int i = 0; i < capacidad; i++)
            {
                numeros += numero[i];
                promedio = (numeros) / capacidad;
            }
            Console.Write("-++- /// El elemento promedio del vector es:");
            Console.WriteLine(promedio);
        }
        public void menor(ref int[] numero)
        {
            int menor = 0;
            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] <= menor)
                {
                    menor = numero[i];
                }
            }
            Console.Write("--- /// El elemento con menor valor del vector es:");
            Console.WriteLine(menor);
        }
        public void positivos(ref int[] numero)
        {
            int[] positivos_v = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                if (numero[i] > 0)
                {
                    positivos_v[i] = numero[i];
                }
            }
            Console.Write("+1+1+ /// Los elementos positivos del vector son:");
            for (int x = 0; x < capacidad; x++)
            {
                Console.Write(positivos_v[x]); Console.Write(", ");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*Escribir funciones que reciban un arreglo de 10 números enteros y devuelvan el
              mayor valor, el menor valor, el valor medio y la suma de todos los valores
              positivos.*/
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = 0; i < capacidad; i++)
            {
                Console.WriteLine("Introduce el dato numero {0}", i);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            Funciones f = new Funciones();
            f.mayor(ref numero);
            f.medio(ref numero);
            f.menor(ref numero);
            f.positivos(ref numero);
            Console.ReadKey();
        }
    }
}
