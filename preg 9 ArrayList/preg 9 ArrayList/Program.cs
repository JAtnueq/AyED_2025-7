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
            /*Escribe un programa en Csharp para copiar una lista de arrays en otra.*/
            ArrayList miLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Tung");
            miLista.Add("Tung");
            miLista.Add("Tung");
            miLista.Add("Sahur");
            //- 7 elementos -----------------------------
            // (Tambien se cuenta el "0")
            Console.WriteLine("Contenido actual del Array [miLista]:");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("¿Copiar el Array? (Apretar Enter)");
            Console.ReadLine();
            //---------------------------------------

            Console.WriteLine("El nuevo Array se llama [miListaCopia]");
            Console.WriteLine("(a diferencia de [miLista], [miListaCopia] esta ordenada)");
            ArrayList miListaCopia = new ArrayList();
            for (int i = 0; i < miLista.Count; i++)
            {
                miListaCopia.Add(miLista[i]);
                miListaCopia.Sort();
            }
            Console.WriteLine("\nContenido de [miLista]");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nContenido de [miListaCopia]");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miListaCopia)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
    }

}