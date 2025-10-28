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
            //------------Contenido del Array--------------
            miLista.Add("Cobre");
            miLista.Add("Oro");
            miLista.Add("Diamante");
            miLista.Add("Amatista");
            miLista.Add("Jade");
            miLista.Add("Rubi");
            miLista.Add("Hierro");
            miLista.Add("Tito Calderon");
            //-8 elementos -----------------------------
            //-(Se incluye 0)-----------------------------
            Console.WriteLine("Contenido actual del Array:");
            for (int i = 0; i < miLista.Count; i++)
            {
                Console.Write("\nElemento [{0}] : ", i); Console.WriteLine(miLista[i]); 
            }
                
            Console.WriteLine("\nPresiona enter para continuar...");
            Console.ReadLine();
            Console.Clear();

            int x;

            Console.WriteLine("Que elemento quiere recuperar");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(miLista[x]);
            Console.WriteLine("¡Recuperado!");
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}

