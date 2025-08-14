using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 números. La computadora muestra el valor máximo e indica la
             cantidad de veces que apareció y el número de orden en que fue ingresado.*/
            int maximo = 0, cont = 1, orden = 0;
            int capacidad = 10;
            int[] numero = new int[capacidad];
            for (int i = capacidad - 1; i >= 0; i--)
            {
                Console.WriteLine("Introduce el dato numero {0}", i + 1);
                numero[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = capacidad-1; i >= 0; i--)
            {
                
                if (numero[i]==maximo)
                {
                    maximo = numero[i];
                    cont += 1;              //verifica antes si el numero de la celda i esta repetido 
                }
                if (maximo <= numero[i])
                {
                    maximo = numero[i];     //Lo principal, remplaza al valor maximo / actualiza
                    orden = i;
                }
                if (i == 0)
                {
                    Console.WriteLine("El valor maximo del vector fue: "+maximo);
                    Console.WriteLine("Aparecio un total de: "+ cont);
                    Console.WriteLine("Siendo la celda {"+(orden+1)+"} la ultima aparicion del numero");
                    Console.ReadKey();
                }
            }
        }
    }
}
