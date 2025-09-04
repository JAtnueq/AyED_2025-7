using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaVector
{
    class PruebaVector
    {
        private string[] nombre;

        public void Cargar()
        {
            nombre = new string[5];
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.Write("Ingrese el {0}° nombre:",i+1);
                nombre[i] = Console.ReadLine();
            }
        }

        public void Ordenar()
        {                                                                                                                                                                                                                                                                                                                                  
            for (int k = 0; k < 4; k++)
            {
                for (int i = 0; i < 4 - k; i++)
                {
                    if (nombre[i].CompareTo(nombre[i + 1]) > 0)
                    {
                        string aux;
                        aux = nombre[i];
                        nombre[i] = nombre[i + 1];
                        nombre[i + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Los nombres ordenados en forma alfabéticamente");
            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine(nombre[i]);
            }
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}