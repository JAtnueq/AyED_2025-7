using System;
using System.Collections.Generic;
using System.Collections; // Sin esta linea, no te toma las declaraciones de ArrayList
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_1_ArraysList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa CSharp para crear una lista de arrays, añadir
              colores (cadenas) e imprimir la colección.*/
            ArrayList miLista = new ArrayList();
            miLista.Add("Teto");
            miLista.Add("Azul");
            miLista.Add("Amarillo");
            miLista.Add("Hola mundo");
            miLista.Add("juas juas");
            miLista.Add(":Vvvv");
            Console.WriteLine("Contenido actual:");
            foreach (string frase in miLista)
                Console.WriteLine(frase);
            Console.ReadKey();
        }
    }
}
