using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13___PINZÓN_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 01 - Clase persona
            Console.WriteLine("EJERCICIO # 01 - PERSONA ");
            PERSONA persona = new PERSONA();
            persona.nombre = "Damaris Castillo";
            persona.edad = 19;
            persona.altura = 1.70;
            persona.estudiante = true;
            persona.MostrarPersona();

            //Ejercicio 02 - clase vehiculo
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 02 - VEHICULO");
            VEHICULO vehiculo = new VEHICULO();
            vehiculo.marca = "Volvo";
            vehiculo.modelo = "XC90 ";
            vehiculo.anio = 2016;
            vehiculo.color = "Negro";
            vehiculo.placa = "P-159JMF";
            vehiculo.VehiculoIn();

            //Ejercicio 03 - Clase producto
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 03 - PRODUCTO");
            //Objeto 01
            PRODUCTO producto1 = new PRODUCTO();
            producto1.codigo = "GA-012";
            producto1.nombre = "Galleta de chocolate";
            producto1.precio = 6;
            producto1.stock = 50;
            producto1.disponible = true;
            //Objeto 2
            PRODUCTO producto2 = new PRODUCTO();
            producto2.codigo = "DON-02";
            producto2.nombre = "Dona Glaseada de Fresa";
            producto2.precio = 7.25;
            producto2.stock = 12;
            producto2.disponible = true;
            producto1.MostrarProductos();
            Console.WriteLine();
            producto2.MostrarProductos();

            //EJERCICIO 04 - CLASE MASCOTA
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 04 - MASCOTA");
            MASCOTA mascota = new MASCOTA();
            mascota.nombre = "Cachupin";
            mascota.especie = "Perro";
            mascota.edad = 7;
            mascota.peso = 25.4;
            mascota.vacunado = true;
            mascota.MostrarMascota();
        }
    }
}
