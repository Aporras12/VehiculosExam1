
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace vehiculosVenta
{
    static class MenuOpciones
    {
        static MenuOpciones() { }
        static Vehiculos vehiculo = new Vehiculos();
   
       // confg Menu
       
        public static void menuOpciones()
        {
            byte opcion = 1;
            do
            {

                Console.WriteLine("*** Menu de opciones ***");
                Console.WriteLine("1- Vehiculo");
                Console.WriteLine("2- Ventas");
                Console.WriteLine("3- Reportes");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");

                Console.Write("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: vehiculos(); break;
                    case 2: break;
                    case 3: break;
                    case 4: break;

                    default:
                        Console.WriteLine("Opcion no disponible");
                        break;
                }
            } while (opcion != 4);
        }

        // confg sub menu de opciones

        public static void vehiculos()
        {

            byte opcion = 1;
            do
            {

                Console.WriteLine("** Sub menu de opciones **");
                Console.WriteLine("1- Agregar Vehiculo");
                Console.WriteLine("2- Modificar Vehiculo");
                Console.WriteLine("3- Consultar Vehiculo");
                Console.WriteLine("4- Salir");
                Console.WriteLine("Digite una opcion");

                Console.Write("Seleccione una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1: vehiculo.Agregar_vehiculos(); break;
                    case 2: vehiculo.Modificar_vehiculos(); break;
                    case 3: vehiculo.Consultar_Vehiculos(); break;
                    case 4: menu(); break;


                    default:
                        Console.WriteLine("Opcion no disponible");
                        break;
                }
            } while (opcion != 4);
        }

    }
}
