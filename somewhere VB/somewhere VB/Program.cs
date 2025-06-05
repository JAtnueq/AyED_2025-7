using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradosyRadianes_VB
{
    class Program
    {
        static void pasaje()
        {
            double grado ;
            Console.WriteLine("Ingresa el valor en grados para pasar a radianes");
            grado = Convert.ToInt32(Console.ReadLine());  
            double pi = Math.PI;
            double resultado;
            resultado = 0;
            resultado = (grado * pi / 180);
            Console.WriteLine("Son en total: " + resultado);
        }
        static void Main(string[] args)
        {
        //1 - Realizar una función que para transformar grados en radianes
        
        Console.WriteLine("Grados -----> Radianes");
        pasaje();
     
        Console.ReadKey();
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
    y = temp;*/

}

