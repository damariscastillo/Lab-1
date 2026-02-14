using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
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
            Console.WriteLine("Hola," + nombre + " Bienvenido a C#");
            Console.WriteLine();
            //Salida de datos

            //Ejercicio 1
            Console.WriteLine("Ejercicio 1");
            string name = "Damaris";
            int entero = 35;
            float dec = 5.5f;
            bool boss = true;

            Console.WriteLine("El nombre del personaje es " + name + " , El nivel del personaje es " + entero + ", Los puntos de vida son " + dec + ", Es un jefe " + boss);
            Console.WriteLine();

            //Ejercicio 2
            Console.WriteLine("Ejecicio 2");
            int numeroEntero = 1500;
            long numerolargo;
            numerolargo = numeroEntero;
            float numerodecimal;
            numerodecimal = numerolargo;
            Console.WriteLine(" Valor final es " + numerodecimal);
            Console.WriteLine();

            //Ejercicio 3
            Console.WriteLine("Ejercicio 3");
            double precioExacto = 45.89;
            int precioRedondeado;
            precioRedondeado = (int)precioExacto;

            Console.WriteLine("El precio exacto es " + precioExacto);
            Console.WriteLine("El precio redondeado es " + (int)precioRedondeado);
            Console.WriteLine();

            //Ejercicio 4
            Console.WriteLine("Ejercicio 4");
            Console.WriteLine("Ingresa un numero ");
            string entradaUsuario = Console.ReadLine();
            int num2 = int.Parse(entradaUsuario);
            int suma = num2 + 5;
            Console.WriteLine("El resultado del numero +5 es: " + suma);
            Console.WriteLine();


            //Ejercicio 5
            Console.WriteLine("Ejercicio 5");
            string valorBooleano = "True";
            bool valor = Convert.ToBoolean(valorBooleano);
            string valorDecimal = "25.5";
            double valor2 = Convert.ToDouble(valorDecimal);
            Console.WriteLine("El valor es " + valor);
            Console.WriteLine("El valor decimal es " + valor2);
            Console.WriteLine();


            //Ejercicio 6
            Console.WriteLine("Ejercicio 6");
            double pi = 3.14159265;
            string textopi = pi.ToString();
            Console.WriteLine("El numero pi es " + textopi);
            //Reto
            String decimales2 = pi.ToString("F2");
            Console.WriteLine("El numero pi con dos decimales es " + decimales2);
            Console.WriteLine();

            //Ejercicio 7
            Console.WriteLine("Ejercicio 7");
            Console.WriteLine("Ingresar precio del producto");
            string precioproducto =  Console.ReadLine();
            double precio = Convert.ToDouble(precioproducto);
            double iva = precio * 0.21;
            double precioFinal = precio + iva;
            int totalEntero = (int)precioFinal;
            Console.WriteLine("El total a pagar es: " + totalEntero);
            Console.WriteLine();
        }
    }
}
