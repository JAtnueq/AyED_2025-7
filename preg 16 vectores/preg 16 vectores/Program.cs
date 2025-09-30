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
            /*16. Cargar un array de n enteros y calcular la media de los que estén en
                  posiciones pares*/
            int n = 0;
            Console.WriteLine("--- Tamaño Vector ---");
            Console.WriteLine("¿De cuantos elementos sera el vector?");
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
            int suma = 0;
            int media = 0;
            int cantidad = 0;
            //-------------
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) // si el índice es impar
                {
                    suma += vector[i];
                    cantidad += 1;
                }
            }
            media = suma / cantidad;
            Console.WriteLine("La media es de las posiciones pares es: " + media);
            /*
         ------- Como declarar ArraysList´s----------
             * ArrayList datos = new ArrayList();
         ------- Añadir elementos a un array list ------
             *datos = add(8);
           *Si queremos que el usuario añada sus datos
             *datos = add(n);
             *n= 8 //n es declaradado anteriormente por el usuario     
         ------- Foreach -------------------------------------    
            foreach(tipo {identificador} in expresion)
           *ejemplo
             foreach(int valor in costo)
             {
                Console.WriteLine("El valor es {0}", valor);
             }
         ------ Cuantos elementos hay en un vector------
             Elementos = datos.count; 
         ------ Insertar un elemento en un array list --------
             Elementos = datos.insert(n,m)
           *n = indice del array
           *m = valor que quiero insertar 
         ------ Remover datos --------------------------------
             Elementos = datos.RemoveAt(n)
         ----- buscar un elemento en un array ------------
             indice = datos.indexof(7)
           *ejemplo
             if (indice == -1)
                Console.WriteLine("Encontrado")
             Else
             Console.WriteLine("No encontrado")       
             */

        }
    }
}