using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusyFarenheit
{
    class Program
    {
        static void conversion()
        {
            int C;
            float F;
            Console.WriteLine("¿Cuantos grados quieres pasar?");
            C = Convert.ToInt32(Console.ReadLine());
            F = ((C * 9 / 5) + 32);
            Console.WriteLine(C + "C° ----> " + F + "F°");
        }
        static void Main(string[] args)
        {
            //2 - Realizar una función para convertir grados Celsius a Fahrenheit
            Console.WriteLine("Celsius---->Fahrenheit");
            conversion();
            Console.ReadKey();
        }
    }
}
