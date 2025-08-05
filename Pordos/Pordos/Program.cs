using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pordos
{

    class Surtidor
    {
        public int cantGasoil = 10000;
        public int cantSuper = 10000;
        public int cantFangio = 10000;
        public void llenarGasoil()
        {
            cantGasoil = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void llenarSuper()
        {
            cantSuper = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void llenarFangio()
        {
            cantFangio = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void CargarGasoil()
        {
            int litros, pendiente;
            Console.WriteLine("¿Cuanto Gasoil va a llenar? (Introducir en litros)");
            litros = Convert.ToInt32(Console.ReadLine());
            if (cantGasoil >= litros)
            {
                cantGasoil -= litros;
                Console.WriteLine("Se ha completado la carga");
            }
            else
            {
                pendiente = (litros - cantGasoil);
                cantGasoil = 0;
                Console.WriteLine("No se a podido completar la carga, quedaron pendientes " + pendiente + "L");
            }
        }
        public void CargarSuper()
        {
            int litros, pendiente;
            Console.WriteLine("¿Cuanto Super va a llenar? (Introducir en litros)");
            litros = Convert.ToInt32(Console.ReadLine());
            if (cantSuper >= litros)
            {
                cantSuper -= litros;
                Console.WriteLine("Se ha completado la carga");
            }
            else
            {
                pendiente = (litros - cantSuper);
                cantSuper = 0;
                Console.WriteLine("No se a podido completar la carga, quedaron pendientes " + pendiente + "L");
            }
        }
        public void CargarFangio()
        {
            int litros, pendiente;
            Console.WriteLine("¿Cuanto Fangio va a llenar? (Introducir en litros)");
            litros = Convert.ToInt32(Console.ReadLine());
            if (cantFangio >= litros)
            {
                cantFangio -= litros;
                Console.WriteLine("Se ha completado la carga");
            }
            else
            {
                pendiente = (litros - cantFangio);
                cantFangio = 0;
                Console.WriteLine("No se a podido completar la carga, quedaron pendientes " + pendiente + "L");
            }
        }
        public void consultar()
        {
            Console.WriteLine("Deposito de Gasoil: " + cantGasoil);
            Console.WriteLine("Deposito de Super: " + cantSuper);
            Console.WriteLine("Deposito de Fangio: " + cantFangio);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int op = 9;
            int op2 = 9;
            Surtidor s = new Surtidor();
            while (op != 0)
            {
                Console.WriteLine("------------Menu------------");
                Console.WriteLine("1. Llenar un surtidor");
                Console.WriteLine("2. Cargar un combustible");
                Console.WriteLine("3. Consultar surtidores");
                Console.WriteLine("0. Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("¿Que Surtidor piensa llenar?");
                        Console.WriteLine("1. Gasoil");
                        Console.WriteLine("2. Super");
                        Console.WriteLine("3. Fangio");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                s.llenarGasoil();
                                break;
                            case 2:
                                s.llenarSuper();
                                break;
                            case 3:
                                s.llenarFangio();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("¿Que combustible cargara?");
                        Console.WriteLine("1. Gasoil");
                        Console.WriteLine("2. Super");
                        Console.WriteLine("3. Fangio");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        switch (op2)
                        {
                            case 1:
                                s.CargarGasoil();
                                break;
                            case 2:
                                s.CargarSuper();
                                break;
                            case 3:
                                s.CargarFangio();
                                break;
                        }
                        break;
                    case 3:
                        s.consultar();
                        break;
                    default:
                        Console.WriteLine("Escoja una opcion que este en los parametros ");
                        break;
                }
            }
        }
    }
}
