using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13___PINZÓN_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class VEHICULO
    {
        public string marca;
        public string modelo;
        public int anio;
        public string color;
        public string placa;

        public void VehiculoIn()
            {
            Console.WriteLine("Información del vehículo: ");
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Año: " + anio);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Placa: " + placa);

        }
}
}
