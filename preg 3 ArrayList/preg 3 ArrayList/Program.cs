using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_3_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa Csharp para insertar un elemento en la lista del
              Array en la primera posición.*/
            ArrayList miLista = new ArrayList();
            String n;
            Console.WriteLine("Inserta algo en la ArrayList:");
            n = Console.ReadLine();
            miLista.Insert(0, n);
            /*------ Insertar un elemento en un array list --------
              Elementos = datos.insert(n,m)
               n = indice del array
               m = valor que quiero insertar */
            Console.WriteLine("Contenido actual:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.ReadKey();
        }
    }
}
