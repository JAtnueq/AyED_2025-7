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
            /*Escribe un programa Csharp para iterar por todos los elementos de una
              lista de arrays.*/
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
            /*Esto fue segun lo que entendi XDD*/
            // --- Actualizacion ---
            // Me di cuenta que la consigna anterior (1) y esta (2) son lo mismo
            // nada mas es para practicar los bucles para imprimir los datos
        }
    }
}
