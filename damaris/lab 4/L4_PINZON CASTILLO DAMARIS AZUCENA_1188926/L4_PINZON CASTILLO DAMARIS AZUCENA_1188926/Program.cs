using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace L4_PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de usuario
            Console.WriteLine("¿Como te llamas? ");
            string nombre;
            nombre = Console.ReadLine();
            Console.WriteLine("Hola," +nombre+ " Bienvenido a C#");
            //Salida de datos
            
            Console.WriteLine("Nombre del personaje ");
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Nivel del personaje ");
            int entero = 32; //Numero entero

            Console.WriteLine("El nombre del personaje es " + name);
            Console.WriteLine("El nivel del personaje es " + entero);





        }
    }
}
