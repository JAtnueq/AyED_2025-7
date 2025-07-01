using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Operaciones
{
    class Operaciones
    {
        public int x, y, resultado;
        public void datos()
        {
            Console.WriteLine("Ingresar datos (X, Y)");
            Console.Write("X = ");
            x = Convert.ToInt16(Console.ReadLine());
            Console.Write("Y = ");
            y = Convert.ToInt16(Console.ReadLine());
        }
        public void suma()
        {
            resultado = x + y;
            Console.WriteLine("x + y = " + resultado);
        }
        public void resta()
        {
            resultado = x - y;
            Console.WriteLine("x - y = " + resultado);
        }
        public void multiplicacion()
        {
            resultado = x * y;
            Console.WriteLine("x * y = " + resultado);
        }
        public void division()
        {
            resultado = x / y;
            Console.WriteLine("x / y = " + resultado);
            resultado = x % y;
            Console.WriteLine("Con un resto de: " + resultado);
        }
    }
            
    class main
    {
        static void Main(string[] args)
        {
           Operaciones op = new Operaciones();
           op.datos();
           op.suma();
           op.resta();
           op.multiplicacion();
           op.division();
           Console.ReadKey();
        }
    }
}
