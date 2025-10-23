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
            /*Escribe un programa Csharp para actualizar un elemento de array con el
              elemento dado.*/
            ArrayList miLista = new ArrayList();
            //------------Contenido del Array--------------
            miLista.Add("Cafeteras");
            miLista.Add("Oso");
            miLista.Add("Fantasma");
            miLista.Add("Ladrillos");
            miLista.Add("Italiano");
            miLista.Add("EL pan de ayer:");
            miLista.Add("Propiedades");
            //- 0-6 elementos -----------------------------
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

            int x;

            Console.WriteLine("¿De quien estoy hablando? (Famoso Italiano)");
            // Inserta el valor dado en la posicion 7
            miLista.Insert(7, Console.ReadLine());
            //---------------------------------------
            Console.Clear();
            Console.WriteLine("Lista actualizada");
            Console.WriteLine("--------------------------------------");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
            
        }
    }
}