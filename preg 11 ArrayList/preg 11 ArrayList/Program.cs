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
            /*Escribe un programa en Csharp para comparar dos listas de arrays.*/
            ArrayList miLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Clasico");
            miLista.Add("Estatico");
            miLista.Add("Maniatico");
            miLista.Add("Romantico");
            miLista.Add("Como antes");
            // (Tambien se cuenta el "0")
            Console.WriteLine("Contenido actual del Array [miLista]:");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("¿Crear un nuevo Array? (Apretar Enter)");
            Console.ReadLine();
            //---------------------------------------

            Console.WriteLine("El nuevo Array se llama [miListaCopia]");
            Console.WriteLine("(a diferencia de [miLista], [miListaCopia] es diferente)");
            ArrayList miListaCopia = new ArrayList();
            //-------- Creacion de la copia ---------
            for (int i = 0; i < miLista.Count; i++)
            {
                miListaCopia.Add(miLista[i]);
            }
            //---------------------------------------
            Console.WriteLine("\nComparando [miLista] y [miListaCopia]");
            Console.WriteLine("\nContenido de [miLista]");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nContenido de [miListaCopia]");
            Console.WriteLine("--------------------------------------");
            miListaCopia.Reverse(0 , miListaCopia.Count);
            foreach (string frase in miListaCopia)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("¿Sabes cual es la diferencia?");
            Console.ReadKey();

        }
    }



}

