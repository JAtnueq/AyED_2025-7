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
            /*Escribe un programa en Csharp para reorganizar elementos en una lista
              de arrays.*/
            ArrayList miLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Fisura");
            miLista.Add("Quebrado");
            miLista.Add("Polenta");
            miLista.Add("Mufa");
            miLista.Add("Frio");
            miLista.Add("Burro");
            miLista.Add("Animal");
            miLista.Add("Gato");
            miLista.Add("Dictadura");
            miLista.Add("Mexico");
            miLista.Add("Peru");
            miLista.Add("Clave");
            miLista.Add("Piedru");
            miLista.Add("Cerru");
            //---------------------------------------------
            //        (Tambien se cuenta el "0")
            Console.WriteLine("Contenido actual del Array [miLista]:");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Mezclar Array (Apretar Enter)");
            Console.ReadLine();
            //---------------------------------------

            Console.WriteLine("Contenido por defecto de [miLista]");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.Write("Elemento [{0}] : ", i); Console.WriteLine(miLista[i]);
            }
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("\nContenido mezclado [miLista]");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < miLista.Count; i++)
            {
                miLista.Reverse();
                Console.Write("Elemento [{0}] : ", i); Console.WriteLine(miLista[i]);
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();

        }
    }

}