using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesFundamentales
{
    //Realizar una clase que realice las 4 operaciones
    class Operaciones
    {
        /*public int = valores que pueden usar todas las clases
          private int = valores que solamente son usadas en esa clase*/
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
/*namespace PruebaClase1
{
    class Persona
    {
        private string nombre;
        private int edad;
        public void Inicializar()

        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }
        public void Imprimir()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }
        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Persona per1 = new Persona();
            per1.Inicializar();
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}*/
