using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L08_Pinzon_Castillo_Damaris_Azucena_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalNum = 20;
            int numeroMayor = 0;
            int numeroingresado;
            int numeroMenor = int.MaxValue;
            double promedio;
            double suma = 0;
            //Ejercicio 01  Programa que permita solicitar 20 números al usuario.
            Console.WriteLine("Ejercicio #01 ");
            for (int i = 1; i <= totalNum; i++)
            {
                Console.WriteLine("Ingrese numero " + i + ":");
                numeroingresado = Convert.ToInt32(Console.ReadLine());
                suma = suma + numeroingresado;
                if (i == 1)
                {
                    numeroMayor = numeroingresado;
                    numeroMenor = numeroingresado;
                }
                else
                {
                    if (numeroingresado > numeroMayor)
                    {
                        numeroMayor = numeroingresado;
                    }
                    if (numeroingresado < numeroMenor)
                    {
                        numeroMenor = numeroingresado;
                    }
                }

            }
            //Calculo del promedio
            promedio = suma / totalNum;
            //Muestra de resultados
            Console.WriteLine("El número mayor es: " + numeroMayor);
            Console.WriteLine("El número menor es: " + numeroMenor);
            Console.WriteLine("El promedio de todos los números es: " + promedio);
            Console.WriteLine();

            //Ejercicio 02 - numeros del 1 al 100
            Console.WriteLine("Ejercicio #02 ");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i + " ParSiete");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i + " Par");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine(i + " Siete");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Ejercicio 03 - Tienda
            Console.WriteLine();
            Console.WriteLine("Ejercicio #03 - Tienda");
            double totalVentas = 0;
            int clientesDescuento = 0;
            int totalClientes = 10;
            for (int i = 1; i <= totalClientes; i++)
            {
                Console.WriteLine("Cliente número: " + i);
                Console.Write("Ingrese el monto de la compra: ");
                double monto = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                double descuento = 0;
                if (monto > 700)
                {
                    descuento = monto * 0.12;
                    clientesDescuento++;
                }
                else if (monto > 300)
                {
                    descuento = monto * 0.05;
                    clientesDescuento++;
                }
                else
                {
                    descuento = 0;
                }
                
               double totalPagar = monto - descuento;
               Console.WriteLine("Total pagado por el cliente " + i + ": " + totalPagar);
                Console.WriteLine();
               totalVentas = totalVentas + totalPagar;
            }
            Console.WriteLine("Clientes que recibieron descuento: " + clientesDescuento);
            Console.WriteLine("Total de ventas del día Q: " + totalVentas);

            //Ejercicio 04 - Numero entero
            Console.WriteLine();
            Console.WriteLine("Ejercicio #04");
            Console.WriteLine("Ingrese un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("1. Mostrar desde " + numero + " hasta");
            Console.WriteLine("2. Mostrar múltiplos de 3 hasta " + numero);
            Console.WriteLine("3. Mostrar múltiplos de 5 hasta " + numero);
            Console.Write("Ingresar una opcion (1,2 o 3): ");
            int opcion = int.Parse(Console.ReadLine());
            //Mostrar los números desde el número ingresado hasta 1
            if (opcion == 1)
            {
                    int i = numero;
                    while (i >= 1)
                    {
                        Console.Write(i + " ");
                        i--;
                    }
            }// Mostrar los múltiplos de 3 hasta el número ingresado
            else if (opcion == 2)
            {
                int i = 3;
                while (i <= numero)
                {
                    Console.Write(i + " ");
                    i += 3;
                }
            }
            else if (opcion == 3)              //Mostrar los múltiplos de 5 hasta el número ingresado
            {
                int i = 5;
                while (i <= numero)
                {
                    Console.Write(i + " ");
                    i += 5;
                }
            }
            Console.WriteLine();
                

                //Ejercicio 05 - triangulo de asteriscos
                Console.WriteLine();
            Console.WriteLine("Ejercicio #05 - Triangulo de asteriscos ");
            Console.WriteLine("Ingrese el numero de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= filas; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
