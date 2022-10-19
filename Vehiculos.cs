using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculosVenta
{
    internal class Vehiculos
    {
        // creacion de atributos protegidos

        protected int codigo { get; set; }
        protected string marca { get; set; }
        protected float costo { get; set; }
        protected string modelo { get; set; }

        public Vehiculos(int codigo, string marca, float costo, string modelo)
        {
            this.codigo = codigo;
            this.marca = marca;
            this.costo = costo;
            this.modelo = modelo;
        }

        int[] Codigo = new int[5];
        String[] Marca = new String[5];
        float[] Costo = float[5];
        String[] Modelo = new String[5];

        
        int i = 0;
        Tipo tipo = new Tipo();

        
        public static Boolean buscar(int[] arreglo, int buscar)
        {
            Boolean result = false;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (buscar == arreglo[i])
                {
                    result = true;
                }
            }
            return result;
        }

       //creacion de metodos solicitados

        public void Modificar_vehiculos()
        {
            int codigo;
            Boolean existe = false;
            Console.WriteLine("Consulta el codigo del vehiculo"); codigo = int.Parse(Console.ReadLine());


            for (int i = 0; i < 5; i++)
            {
                if (codigo == Codigo[i])
                {
                    Console.WriteLine("Ingrese el codigo del veihiculo:"); Codigo[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la marca del veihiculo:"); Marca[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el modelo veihiculo:"); Modelo[i] = Console.ReadLine();
                    Console.WriteLine("Ingrese el costo del veihiculo:"); Costo[i] = float.Parse(Console.ReadLine());
                    existe = true;
                  
                }
            }
            if (!existe) Console.WriteLine("Vehiculo no existe");
        }
 

        public void Consultar_Vehiculos()
        {
            int codigo;
            Boolean existe = false;
            Console.WriteLine("Consulta el codigo del vehiculo a Consultar"); codigo = int.Parse(Console.ReadLine());
            
            for (int i=0; i<5; i++)
            {
                if(codigo == Codigo[i])
                {
                    
                    Console.WriteLine($"marca: {marca[i]}");
                    Console.WriteLine($"modelo: {modelo[i]}");
                    existe= true;

                }

            }
            if (!existe) Console.WriteLine("Vehiculo no existe");

        }


        public void Agregar_vehiculos()
        {

            if (i < 5)
            {
                Console.WriteLine("Ingrese el codigo del veihiculo:"); Codigo[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la marca del veihiculo:"); Marca[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el modelo veihiculo:"); Modelo[i] = Console.ReadLine();
                Console.WriteLine("Ingrese el costo del veihiculo:"); Costo[i] = float.Parse(Console.ReadLine());
                Console.WriteLine("Vehiculo ingresado correctamente");


                Console.WriteLine($"Codigo del vehiculo: {Codigo[i]}\n" +
                    $"Marca del vehiculo: {Marca[i]}\n" +
                    $"Modelo del vehiculo: {Modelo[i]}\n" +
                    $"Costo del vehiculo: ${Costo[i]}\n");

                Console.ReadLine();
                Console.Clear();
                i++;
                MenuOpciones.menuOpciones();
            }
            else
                Console.WriteLine("`Se agrego el total de vehiculos");
            Console.ReadLine();
            Console.Clear();


        }

        public void mostrar_todo()
        {
            int existe = 0;
            for (int i = 0; i < Codigo.Length; i++)
            {
                if (existe == Codigo[i])
                {
                    Console.ReadLine();
                    Console.Clear();
                    MenuOpciones.menuOpciones();
                }
                Console.WriteLine($" El Codigo del vehiculo: {Codigo[i]}\n" +
                $"La marca del vehiculo: {Marca[i]}\n" +
                $"El modelo del vehiculo: {Modelo[i]}\n" +
                $"El costo por el vehiculo: ${Costo[i]}\n");

            }

        }
    }
}