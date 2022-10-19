using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculosVenta
{
    internal class Tipo
    {
        List<String> tipos = new List<String> { "Motocicleta", "Automovil", "Dron" };

        public Boolean BuscarTipo(string valor)
        {
            Boolean exist = tipos.Contains(valor);

            if (exist)
            {
                Console.WriteLine("Tipo de Vehiculo existe");
            }
            else
                Console.WriteLine("Tipo de Vehiculo no existe");
        }

        public void Tipo_vehiculo()
        {
            Console.WriteLine("Existen diferentes tipos de vehiculos");
        }

    }

}