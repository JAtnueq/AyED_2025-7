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
            /*Escriba un programa Csharp para recuperar un elemento (en un índice
              específico) de una lista de arrays dada.*/
            ArrayList miLista = new ArrayList();

            miLista.Add("Hola mundo");
            miLista.Add("juas juas");
            miLista.Add(":Vvvv");

            Console.WriteLine("Contenido actual del Array:");
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.WriteLine(miLista());
            }

            miLista.RemoveAt(1);
            Console.WriteLine("Oh no, se perdio el contenido del indice 1 (Enter = continuar)");
            Console.ReadLine();
            Console.WriteLine("Recuperando...");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
