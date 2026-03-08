using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L6_PINZON_CASTILLO_DAMARIS_1188926
{
    internal class Program
    {
        static void Main()
        {
            //EJERCICIO 1
            //CONVERSIÓN DE TEMPERATURAS
            Console.WriteLine("- Ejercicio #1: Conversion de temperaturas - ");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine();
            Console.Write("Ingresar una opcion (1,2 o 3): ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //Temperatura de celsius a fahrenheit
                    Console.WriteLine("Ingrese temperatura en Celsius: ");
                    double conversion;
                    double temperatura = Convert.ToDouble(Console.ReadLine());
                    conversion = (temperatura * 9 / 5) + 32;
                    Console.WriteLine("La temperatura " + temperatura + "°C en Fahrenheit es de " + conversion + "°F");
                    break;
                case 2:
                    //Temperatura en fahrenheit a celsius
                    Console.WriteLine("Ingrese temperatura en Fahrenheit: ");
                    double temperatura2 = Convert.ToDouble(Console.ReadLine());
                    conversion = (temperatura2 - 32) * 5 / 9;
                    Console.WriteLine("La temperatura " + temperatura2 + "°F en Celsius es de " + conversion + "°C");
                    break;
                case 3:
                    //Temperatura en celsius a kelvin
                    Console.Write("Ingrese temperatura en Celsius: ");
                    double temperatura3 = Convert.ToDouble(Console.ReadLine());
                    conversion = (temperatura3 + 273.15);
                    Console.WriteLine("La temperatura " + temperatura3 + "°C en Kelvin es de " + conversion + " K");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Error esa opcion no existe");
                    Console.WriteLine();
                    break;


            }
            //EJERCICIO 2: DESCUENTOS CLIENTE
            Console.WriteLine();
            Console.WriteLine(" - Ejercicio #02: Descuentos cliente - ");
            Console.WriteLine("1. Cliente regular");
            Console.WriteLine("2. Cliente VIP ");
            Console.WriteLine();
            Console.WriteLine("Ingrese cantidad de unidades compradas: ");
            int cantidad= int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingresar una opcion (1 o 2): ");
            int cliente = int.Parse(Console.ReadLine());
            double descuento = 0;
            if (cantidad > 100)
            {
                descuento = 0.15;
            }
            else
            {
                switch (cliente)
                {
                    case 1:
                        descuento = 0.05;
                        break;

                    case 2:
                        descuento = 0.10;
                        break;
                    default:
                        Console.WriteLine("Tipo de cliente no válido.");
                        break;
                }

            }
                Console.WriteLine("Descuento aplicado: " + (descuento * 100) + "%");
                Console.WriteLine();

                //EJERCICIO #3: ESTACIONAMIENTO
                Console.WriteLine();
                Console.WriteLine(" - Ejercicio #03: Estacionamiento - ");
                double tarifahoras = 0;
                double totalpagar;
                Console.WriteLine("Ingrese la cantidad de horas que estuvo estacionado ");
                double horas = double.Parse(Console.ReadLine());
                if (horas < 2)
                {
                    tarifahoras = 5;
                }
                else if (horas >= 2 && horas <= 5)
                {
                    tarifahoras = 4;
                }
                else if (horas > 5)
                {
                    tarifahoras = 3;
                }

                totalpagar = horas * tarifahoras;
                Console.WriteLine();
                Console.WriteLine("Precio por hora: $" + tarifahoras);
                Console.WriteLine("Total a pagar: $" + totalpagar);
                Console.WriteLine();

                //EJERCICIO #04: EMPRESA
                Console.WriteLine("- Ejercicio #04: Evaluacion empresa - ");
                Console.WriteLine();
                Console.WriteLine("Ingrese su puntuación(0.0, 0.4, 0.6 o más)  ");
                double puntuacion = Convert.ToDouble(Console.ReadLine());
                string nivel;
                double BonoBase = 2400.0;
                double incentivo;

                if (puntuacion == 0.0)
                {
                    nivel = "Inaceptable";
                }
                else if (puntuacion == 0.4)
                {
                    nivel = "Aceptable";
                }
                else if (puntuacion >= 0.6)
                {
                    nivel = "Meritorio";
                }
                else
                {
                    nivel = "Invalido";
                }
                if (nivel != "Invalido")
                {
                    incentivo = BonoBase * puntuacion;
                    Console.WriteLine("Nivel de rendimiento: " + nivel);
                    Console.WriteLine("Cantidad de dinero: " + incentivo + " euros");
                }
                else
                {
                    Console.WriteLine("Error: La puntuación no es válida.");
                    Console.WriteLine("Solo se permite 0.0, 0.4 o valores mayores o iguales a 0.6.");
                }
            
        }
    }
}
