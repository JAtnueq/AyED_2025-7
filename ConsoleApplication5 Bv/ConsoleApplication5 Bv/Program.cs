using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grados_y_radianes
{
    class Program
    {
       static double pasaje(ref double x, ref double pi_i)
        {
            double resultado = 0;
            resultado = (x * pi_i / 180);
        }
        static void Main(string[] args)
        {
            //1 - Realizar una función que para transformar grados en radianes
            double a, resultado;
            double pi = Math.PI;
            string grado = "";
            Console.WriteLine("Grados -----> Radianes");
            Console.WriteLine("Ingresa el valor en grados para pasar a radianes");
            grado = Console.ReadLine();
            a = Convert.ToDouble(grado);
            resultado = pasaje(ref a, ref pi);
            Console.WriteLine("Son en total: ", resultado);
            Console.ReadKey();
        }
        
    }
}

/*Variables
int numero = 3;
int numero1 = 5;


//Valor antes de función

Console.WriteLine("Numeros antes de la funcion  numero={0},  numero1={1}", numero, numero1);


            //Invocamos a la funcion

            Cambiar(ref numero, ref numero1);

//Valor despues de la función
Console.WriteLine("Valor despues del cambio numero={0}  , numero1={1}", numero, numero1);
            Console.ReadKey();

        }

        static void Cambiar(ref int x, ref int y)
{

    //Variable de trabajo
    int temp = 0;
    //Cambiamos el valor
    temp = x;
    x = y;
    y = temp;

}*/