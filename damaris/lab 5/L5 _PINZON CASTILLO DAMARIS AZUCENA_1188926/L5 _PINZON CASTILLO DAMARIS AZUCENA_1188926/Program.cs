using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace L5__PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desafio 1: Estructuras selectivas
            Console.Write("Ingresar un numero entero ");
            double num = Convert.ToDouble( Console.ReadLine());
            if (num > 0)
            { Console.WriteLine("El numero es positivo"); }
            else if (num<0)
                    { Console.WriteLine("El numero es negativo"); }
            else { Console.WriteLine("El numero es cero "); }

            //Desafio 2:Estructuras selectivas
            Console.Write("Ingresar año ");
            string fecha = Console.ReadLine();
            if (int.TryParse(fecha, out int anno))
                if ((anno%4 == 0 && anno%100 != 0)|| (anno%400 ==0))
                    { Console.WriteLine("El año " + anno + " Es bisiesto "); }

            //Desafio 3: Estructuras selectivas
            bool multa;
            double ingreso=Convert.ToDouble(Console.ReadLine());
            if (500.01>=1000.00)
            {  }
            else { }
               


        }
    }
}
