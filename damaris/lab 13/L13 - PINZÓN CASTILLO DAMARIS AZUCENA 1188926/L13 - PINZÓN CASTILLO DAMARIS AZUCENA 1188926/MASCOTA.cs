using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13___PINZÓN_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class MASCOTA
    {
        public string nombre;
        public string especie;
        public int edad;
        public double peso;
        public bool vacunado;

        public void MostrarMascota()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Especie: " + especie);
            Console.WriteLine("Edad: " + edad + " años");
            Console.WriteLine("Peso: " + peso + " kg");
            Console.WriteLine("Vacunado: " + vacunado);
        }
    }
}
