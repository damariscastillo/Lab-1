using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13___PINZÓN_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class PRODUCTO
    {
        public string codigo;
        public string nombre;
        public double precio;
        public int stock;
        public bool disponible;

        public void MostrarProductos()
        {
            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Producto:   " + nombre);
            Console.WriteLine("Precio:     " + precio);
            Console.WriteLine("Stock:      " + stock);
            Console.WriteLine("Estado:     " + disponible);
        }
    }
}
