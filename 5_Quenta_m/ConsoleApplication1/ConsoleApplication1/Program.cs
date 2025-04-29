using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dada una fecha de nacimiento, calcular los dias vividos 
            int dia, diaactual, mes, mesactual, año, añoactual;
            Console.WriteLine("Ingresa de a poco que fecha naciste");
            Console.WriteLine("Que dia es");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que mes es");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que año es");
            año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que dia es actualmente");
            diaactual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que mes es actualmente");
            mesactual = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Que año es actualmente");
            añoactual = Convert.ToInt32(Console.ReadLine());
            //while ((año <= 0) || (año >= 2100))
            if ((año <= 0) || (año >= 2100))
            {
                Console.WriteLine("Ingrese un año diferente a 0 ó 2100");
                año = Convert.ToInt32(Console.ReadLine());
            }
            if ((añoactual <= 0) || (añoactual >= 2100))
            {
                Console.WriteLine("Ingrese un año actual diferente a 0 ó 2100");
                añoactual  = Convert.ToInt32(Console.ReadLine());
            }
            while ((dia != diaactual) && (mes != mesactual) && (año != añoactual))

            //------------------Caso: año bisiesto----------------- 
            if ((año % 4 == 0) || (año % 100 != 0) || (año % 400 == 0))
                if (mes == 2)
                    dia += 1;
            //---------------Meses con 31 dias---------------------
            if ((mes == 1) || (mes == 3) || (mes == 4) || (mes == 7) || (mes == 8) || (mes == 10))
                if (diasobra > 31)
                {
                    diasobra -= 31;
                    dia = diasobra + 0;
                    mes += 1;
                }       
            //---------------Meses con 30 dias-----------------
            if ((mes == 4) || (mes == 6) || (mes == 9) || (mes == 11))
                if (diasobra > 30)
                {
                    diasobra -= 30;
                    dia = diasobra + 0;
                    mes += 1;
                }
            //---------------Caso: diciembre---------------------
            if (mes == 12)
                if (diasobra > 31)
                {
                    diasobra -= 31;
                    dia = diasobra + 0;
                    mes = 1;
                    año += 1;
                }
            Console.WriteLine("Seria esta fecha :U");
            Console.Write(dia); Console.Write("/"); Console.Write(mes); Console.Write("/"); Console.Write(año);
            Console.ReadKey();
                

                    
          
        }
    }
}
