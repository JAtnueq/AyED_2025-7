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
            /*Escribe un programa en Csharp para unir dos listas de arrays.*/
            ArrayList miLista = new ArrayList();
            ArrayList TuLista = new ArrayList();
            ArrayList NuestraLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Panico");
            miLista.Add("Estatico");
            miLista.Add("Maniatico");
            miLista.Add("Romantico");
            miLista.Add("Como antes");
            // (Tambien se cuenta el "0")
            Console.WriteLine("Contenido actual del Array [miLista]:");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.Write("Elemento [{0}] : ", i); Console.WriteLine(miLista[i]);
            }
            Console.WriteLine("--------------------------------------");
            TuLista.Add("Clasico");
            TuLista.Add("Estatico");
            TuLista.Add("Es magico");
            TuLista.Add("Como solia ser");
            TuLista.Add("Mi ego conectado al CRT");
            Console.WriteLine("Contenido actual del Array [TuLista]:");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < TuLista.Count; i++)
            {
                Console.Write("Elemento [{0}] : ", i); Console.WriteLine(TuLista[i]);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();


            Console.WriteLine("¿Unir los Arrays? (Apretar Enter)");
            Console.ReadLine();
            //---------------------------------------

            Console.WriteLine("El nuevo Array se llama [NuestraLista]");
            //-------- Creacion de la copia ---------
            for (int i = 0; i < miLista.Count; i++)
            {
                NuestraLista.Add(miLista[i]);
            }
            for (int i = 0; i < TuLista.Count; i++)
            {
                NuestraLista.Add(TuLista[i]);
            }
            //---------------------------------------
            Console.WriteLine("\nContenido de [NuestraLista]");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in NuestraLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
    }
}