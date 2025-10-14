using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace preg_2_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
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
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("¡Otra vez!");
                foreach (string frase in miLista)
                    Console.WriteLine(frase);
            }
            Console.ReadKey();
        }
    }
}
