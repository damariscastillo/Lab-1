using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L13___PINZÓN_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class PERSONA
    {
        public string nombre;
        public int edad;
        public double altura;
        public bool estudiante;

        public void MostrarPersona()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Altura: " + altura);
            Console.WriteLine("Estudiante: " + estudiante);
        }
    }
}
