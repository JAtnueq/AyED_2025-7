using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_4_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa en Csharp para buscar un elemento en una lista de
              arrays.*/
            ArrayList miLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Cafeteras");
            miLista.Add("Oso");
            miLista.Add("Fantasma");
            miLista.Add("Ladrillos");
            miLista.Add("Italiano");
            miLista.Add("EL pan de ayer");
            miLista.Add("Propiedades");
            //- 7 elementos -----------------------------
            // (Tambien se cuenta el "0")
            Console.WriteLine("Contenido actual del Array:");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.Write("Elemento [{0}] : ", i); Console.WriteLine(miLista[i]);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("Introduce algun elemento del Array para saber su posicion/indice");
            string palabra = Console.ReadLine();
            Console.WriteLine("\nLa palabra " + palabra+" está en la posición {0}", miLista.IndexOf(palabra));
            //---------------------------------------
            
            Console.WriteLine("Lista actualizada");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
    }

}