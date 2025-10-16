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
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("¡Otra vez!");
                Console.ReadLine();
                foreach (string frase in miLista)
                    Console.WriteLine(frase);
            }
            Console.ReadKey();
            /*Esto fue segun lo que entendi XDD*/
        }
    }
}
