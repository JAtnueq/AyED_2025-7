using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_area_clases
{
    /*3. En el ejercicio planteado debe realizar el cálculo de un área de un triángulo debe
    crear un método que reciba como parámetro la base del triángulo y la altura del
    mismo y devuelva el valor resultado a una etiqueta o por medio de un mensaje
    emergente.*/
    class Program
    {
        public void proceso(int x, int y)
        {
            int r = 0;
            r = (x * y) / 2;
        }
        static void Main(string[] args)
        {
            int b, h, resultado;
            Console.WriteLine("ingresar base del triangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresar altura del triangulo");
            h = Convert.ToInt32(Console.ReadLine());
            resultado = proceso(b, h);
            Console.ReadKey();
        }
        
        
    }
    
}
/*Variante 2: Debe realizar el mismo cálculo pero con un método que no devuelva
    valores solo que escriba en una variable del segmento de código implementado y
    luego volcar esta variable a la etiqueta o mensaje emergente.
    class area_triangulo
    {
        public void datos_triangulo()
        {
            int b, h, resultado;
            Console.WriteLine("ingresar base del triangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresar altura del triangulo");
            h = Convert.ToInt32(Console.ReadLine());
            resultado = (b * h) / 2;
            Console.WriteLine("El area del triangulo es: " + resultado);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            area_triangulo dt = new area_triangulo();
            dt.datos_triangulo();
            Console.ReadKey();
        }
    }*/