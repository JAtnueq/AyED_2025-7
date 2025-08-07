using System;

namespace Practica
{
    /*Una estacion de serviciocuenta con surtidores de combustible càpaces de proveer Gasoil, Nafta Super y Nafta Fangio 2000.
     Todos los surtidores tienen capacidad para almacenar un maximo de 20000 litros de cada combustible. En cada surtidor se
     mantiene registro de la cantidad de litros disponibles en deposito de cada tipo de combustible. En cada surtidor es posible
     cargar o reponer combustible. En ocasiones la cantidad de un tipo de combustible particular en un surtidor especifico puede
     no ser suficiente para completar una carga, en ese caso se carga lo que se puede y cuando el deposito del surtidor queda vacio
     si no se completo la carga, se muestra un mensaje. Cuando se repone un combustible en el surtidor, se llena el deposito
     completo de ese combustible. Cada vez que un cliente carga una cantidad dada de combustible, se actualiza la cantidad 
     disponible en el deposito correspondiente*/
    class Surtidor
    {
        public int cantGasoil = 10000;
        public int cantSuper = 10000;
        public int cantFangio = 10000;
        public void CargarGasoil()
        {
            Console.WriteLine("¿Cuanto Gasoil va a cargar? (En litros)");
            int litros = Convert.ToInt32(Console.ReadLine());
            if (cantGasoil >= litros)
            {
                cantGasoil -= litros;
                Console.WriteLine("Carga realizada con éxito.");
            }
            else
            {
                int pendiente = litros - cantGasoil;
                Console.WriteLine("Solo se pudieron cargar " + cantGasoil +  "l. Quedaron pendientes " + pendiente + "l");
                cantGasoil = 0;
            }
        }
        public void CargarSuper()
        {
            int litros;
            Console.WriteLine("¿Cuanto Super va a cargar? (En litros)");
            litros = Convert.ToInt32(Console.ReadLine());
            if (cantSuper >= litros)
            {
                cantSuper -= litros;
                Console.WriteLine("Carga realizada con éxito.");
            }
            else
            {
                int pendiente = litros - cantSuper;
                Console.WriteLine("Solo se pudieron cargar " + cantSuper + "l. Quedaron pendientes " + pendiente + "l");
                cantSuper = 0;
            }
        }
        public void CargarFangio()
        {
            int litros;
            Console.WriteLine("¿Cuanto Fangio va a cargar? (En litros)");
            litros = Convert.ToInt32(Console.ReadLine());
            if (cantFangio >= litros)
            {
                cantFangio -= litros;
                Console.WriteLine("Carga realizada con éxito.");
            }
            else
            {
                int pendiente = litros - cantFangio;
                Console.WriteLine("Solo se pudieron cargar " + cantFangio + "l. Quedaron pendientes " + pendiente + "l");
                cantFangio = 0;
            }
        }
        public void LlenarDepositoGasoil()
        {
            cantGasoil = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void LlenarDepositoSuper()
        {
            cantSuper = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void LlenarDepositoFangio()
        {
            cantFangio = 20000;
            Console.WriteLine("Llenado exitosamente");
        }
        public void ConsultadeCombustible()
        {
            Console.WriteLine("Deposito de Gasoil " + cantGasoil + "l");
            Console.WriteLine("Deposito de Super " + cantSuper + "l");
            Console.WriteLine("Deposito de Fangio " + cantFangio + "l");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int op = 9;
            int op2 = 9;
            int op3 = 9;   
            Surtidor s = new Surtidor();
            do
            {
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Cargar un combustible");
                Console.WriteLine("2. Llena un surtidor");
                Console.WriteLine("3. Consultar Surtidores");
                Console.WriteLine("0. Salir");
                op = Convert.ToInt32(Console.ReadLine()); 
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Seleccione el tipo de combustible:");
                        Console.WriteLine("1. Gasoil");
                        Console.WriteLine("2. Super");
                        Console.WriteLine("3. Fangio");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
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
                            default:
                                Console.WriteLine("Opcion no valida");
                                Console.Clear();
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Seleccione el tipo de combustible a llenar:");
                        Console.WriteLine("1. Gasoil");
                        Console.WriteLine("2. Super");
                        Console.WriteLine("3. Fangio");
                        op2 = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        switch (op2)
                        {
                            case 1:
                                s.LlenarDepositoGasoil();
                                break;
                            case 2:
                                s.LlenarDepositoSuper();
                                break;
                            case 3:
                                s.LlenarDepositoFangio();
                                break;
                            default:
                                Console.WriteLine("Opcion no valida");
                                Console.Clear();    
                                break;
                        }
                        break;
                    case 3:
                        s.ConsultadeCombustible();
                        Console.WriteLine("Presione una opcion para continuar...");
                        break;
                    default:
                        {
                            Console.WriteLine("Opcion no valida");
                            Console.Clear();    
                            break;
                        }
                }

            } while (op != 0);
        }
    }
}
