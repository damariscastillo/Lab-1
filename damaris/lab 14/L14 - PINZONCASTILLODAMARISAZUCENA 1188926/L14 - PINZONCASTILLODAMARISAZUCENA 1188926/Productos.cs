using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___PINZONCASTILLODAMARISAZUCENA_1188926
{
    internal class Productos
    {
        string nombre;
        double precio;
        int cantidad;
        //constructor
        public Productos(string nombre, double precio, int cantidad)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        //metodos
        //mostrar información
        public void MostrarInformacion()
        {
            Console.WriteLine("Producto: " + nombre);
            Console.WriteLine("Precio: Q" + precio);
            Console.WriteLine("Stock: " + cantidad);
        }

        //vender
        public void Vender(int cantidadVendida)
        {
            if (cantidadVendida <= cantidad)
            {
                cantidad -= cantidadVendida;
                Console.WriteLine("Venta realizada: " + cantidadVendida + " unidades de " + nombre);
            }
            else {
                Console.WriteLine("Error: No hay suficiente stock de " + nombre + " para vender");
            }
        }

        //reabastecer
        public void Reabastecer(int cantidadNueva)
        {
            if (cantidadNueva > 0)
            {
                cantidad += cantidadNueva;
                Console.WriteLine("Reabastecimiento: Se sumaron " + cantidadNueva + " unidades de " + nombre);
            }
        }
    }
}
