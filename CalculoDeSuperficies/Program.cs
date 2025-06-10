using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSuperficies
{
    class Program
    {
        static void cuadrado()
        {
            int lado, superficie;
            Console.WriteLine("¿Cuanto mide uno de sus lados? (no importa si es su altura o ancho)");
            lado = Convert.ToInt32(Console.ReadLine());
            superficie = lado * lado;
            Console.WriteLine("Su superficie total es de: "+ superficie);
            Console.ReadKey();
        }
        static void triangulo()
        {
            int H, b, superficie;
            Console.WriteLine("¿Cuanto mide su base?");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuanto mide de alto?");
            H = Convert.ToInt32(Console.ReadLine());
            superficie = ((b * H) / 2);
            Console.WriteLine("Su superficie totsl es de: " + superficie);
            Console.ReadKey();
        }
        static void rectangulo()
        {
            int b, h, superficie;
            Console.WriteLine("¿Cuanto mide de ancho?");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("¿Cuanto mide de alto?");
            h = Convert.ToInt32(Console.ReadLine());
            superficie = (b*h);
            Console.WriteLine("Su superficie total es de: " + superficie);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //3-Realizar una función que permita calcular, la superficie de un cuadrado, triangulo y rectángulo
            int opcion; 
            Console.WriteLine("¿Que superficie quieres calcular?");
            Console.WriteLine("!-Cuadrado");
            Console.WriteLine("2-triangulo");
            Console.WriteLine("3-RectAngulo");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:  
                    cuadrado();
                    break;
                case 2:
                    triangulo();
                    break;
                case 3:
                    rectangulo();
                    break;
                default:
                    Console.WriteLine("Escoja alguna de las oopciones que hay :U");
                    break;
            }
        }
    }
}
