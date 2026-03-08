using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L7_PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EJERCICIO #1 WHILE
            Console.WriteLine("Ejercicio #01 - Credenciales");
            string nombre = "Damaris Azucena Pinzón Castillo";
            int carnet = 1188926;
            int indice = 1;
            Console.WriteLine("Nombre: " + nombre + " Carnet: " + carnet.ToString()); 
            while (indice <= 20)
            {
                //Repetir las siguentes instrucciones:
                if (indice % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(indice);
                indice = indice + 1;
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Programa terminado, presione cualquier tecla para salir");
            Console.ReadLine();
            Console.WriteLine();

            //EJERCICIO #2 - DO-WHILE
            Console.WriteLine("Ejercicio #02 - Do-While");
            Console.WriteLine("- Divisores de un numero entero positivo -");
            int enteropositivo;
            int divisor = 1;
            do
            {
                Console.WriteLine("Ingrese un numero positivo");
                enteropositivo = int.Parse(Console.ReadLine());
                if (enteropositivo <= 0)
                {
                    Console.WriteLine("Error: El número debe ser mayor a cero.");
                }
            } while (enteropositivo <= 0);
            Console.WriteLine("Los divisores son: ");
            do
            {
                if (enteropositivo % divisor == 0)
                {
                    Console.WriteLine(divisor);
                }
                divisor++;
            } while (divisor <= enteropositivo);
            Console.WriteLine("Programa terminado, presione cualquier tecla para salir");
            Console.ReadLine();
            Console.WriteLine();

            //EJERCICIO #03 - FOR
            Console.WriteLine("Ejercicio#03 - La serie de Fibonacci ");
            int num, primero = 0, segundo = 1;
            Console.WriteLine("Ingrese un numero entero");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int I = 1; I <= num; I++)
            {
                Console.Write(primero + (I < num ? " - " : ""));
                int suma = primero + segundo;
                primero = segundo;
                segundo = suma;
            }
            Console.WriteLine();
            Console.WriteLine("Programa terminado, presione cualquier tecla para salir");
            Console.ReadLine();

            //EJERCICIO 04 LIBRE tablas de multiplicar
            Console.WriteLine();
            Console.WriteLine("Ejercicio #04 - Libre");
            Console.WriteLine("- Tablas de multiplicar del 1 al 12 -");
            int i;
            int t;
            int resultado;
            for (t = 1; t <= 12; t++)
            {
                Console.WriteLine();
                Console.WriteLine("Tabla del numero " + t);
                for ( i=1; i<=10; i++)
                {
                    resultado = i * t;
                    Console.WriteLine(t + " x " + i + " = " + resultado);
                }
            }
           
            
        }
    }
}
