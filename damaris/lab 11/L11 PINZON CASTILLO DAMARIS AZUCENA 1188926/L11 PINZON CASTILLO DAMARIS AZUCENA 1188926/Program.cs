using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L11_PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" -- EJERCICIO #01 - DETECCION DE PALINDRÓMOS -- ");
            Console.Write("Ingrese una palabra: ");
            string entrada = Console.ReadLine();
            entrada = entrada.ToLower();
            char[] arreglo = new char[entrada.Length];
            for (int i = 0; i < entrada.Length; i++)
            {
                arreglo[i] = entrada[i];
            }

            bool esPalindromo = true;

            for (int i = 0; i < arreglo.Length / 2; i++)
            {
                if (arreglo[i] != arreglo[arreglo.Length - 1 - i])
                {
                    esPalindromo = false;
                    break;
                }
            }
            if (esPalindromo)
            {
                Console.WriteLine("Es un palíndromo");
            }
            else
            {
                Console.WriteLine("No es un palíndromo");
            }

            Console.WriteLine();

            Console.WriteLine(" -- EJERCICIO #02 - TRADUCCION DE PALABRAS -- ");
            string[] español = { "rojo", "azul", "amarillo", "blanco", "verde" };
            string[] ingles = { "red", "blue", "yellow", "white", "green" };
            string[] italiano = { "rosso", "blu", "giallo", "bianco", "verde" };
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine();
                Console.WriteLine(" - Traduccion de palabras - ");
                Console.WriteLine("1. Practicar lección");
                Console.WriteLine("2. Terminar lección");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                if (opcion != "1" && opcion != "2")
                {
                    Console.WriteLine("Error: Opción no válida. Solo puede ingresar 1 o 2.");
                }
                else
                {
                }
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine();
                        Console.Write("Ingrese palabra en español: ");
                        string palabraBuscada = Console.ReadLine().ToLower();
                        int indice = -1;
                        for (int i = 0; i < español.Length; i++)
                        {
                            if (español[i] == palabraBuscada)
                            {
                                indice = i;
                                break;
                            }
                        }
                        if (indice == -1)
                        {
                            Console.WriteLine("Error: La palabra no corresponde a la lección actual. ");
                        }
                        else
                        {
                            Console.WriteLine("Inglés: " + ingles[indice]);
                            Console.WriteLine("Italiano: " + italiano[indice]);
                        }
                        break;

                    case "2":
                        Console.WriteLine();
                        Console.WriteLine("¡Hasta la próxima!");
                        salir = true;
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" -- EJERCICIO #03 - CALIFICACION DE CURSO -- ");
            int[] calificaciones = new int[10];
            Random aleatorio = new Random();
            for (int i = 0; i < calificaciones.Length; i++)
            {
                calificaciones[i] = aleatorio.Next(50, 101); //se usa 101 para que incluya hasta el 100
            }

            int Opcion = 0;

            while (Opcion != 3)
            {
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine(" - MENÚ CALIFICACION DE CURSO - ");
                Console.WriteLine("1. Reporte de rendimiento");
                Console.WriteLine("2. Estadísticas");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Reporte de rendimiento: ");
                        for (int i = 0; i < calificaciones.Length; i++)
                        {
                            int notaActual = calificaciones[i];

                            if (notaActual >= 50 && notaActual <= 64)
                                Console.ForegroundColor = ConsoleColor.Red;
                            else if (notaActual >= 65 && notaActual <= 79)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            else if (notaActual >= 80 && notaActual <= 100)
                                Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("La nota actual es: " + notaActual);
                        }
                        Console.WriteLine();
                        Console.ResetColor();
                        break;

                    case 2:
                        double sumaNotas = 0;
                        int mayor = calificaciones[0];
                        int menor = calificaciones[0];
                        int cantidadElementos = 10;
                        double promedioFinal = 0;

                        for (int i = 0; i < calificaciones.Length; i++)
                        {
                            sumaNotas = sumaNotas + calificaciones[i];
                            if (calificaciones[i] > mayor)
                            {
                                mayor = calificaciones[i];
                            }
                            if (calificaciones[i] < menor)
                            {
                                menor = calificaciones[i];
                            }
                        }

                        promedioFinal = sumaNotas / cantidadElementos;
                        Console.WriteLine();
                        Console.WriteLine("ESTADÍSTICAS: ");
                        Console.WriteLine("Promedio del curso: " + promedioFinal);
                        Console.WriteLine("Calificación más alta: " + mayor);
                        Console.WriteLine("Calificación más baja: " + menor);
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Programa Finalizado.");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine(" -- EJERCICIO #04 - PAGOS A TRABAJADORES -- ");
            string[] nombres = { "Ana", "Mario", "Saúl", "Karla", "María", "José" };
            double[] salarioxhora = { 100, 125.50, 98.65, 125, 132.50, 102.50 };
            double[] horas_laboradas = new double[6];
            Console.WriteLine();
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese las horas laboradas por " + nombres[i] + ": ");
                horas_laboradas[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine(" - RESUMEN DE PAGOS - ");
            for (int i = 0; i < 6; i++)
            {
                double pagoTotal = 0;
                double horas = horas_laboradas[i];
                double sueldoBase = salarioxhora[i];
                if (horas > 40)
                {
                    double pagoOrdinario = 40 * sueldoBase;
                    double horasExtras = horas - 40;
                    double pagoExtra = horasExtras * (sueldoBase * 1.5);
                    pagoTotal = pagoOrdinario + pagoExtra;
                }
                else
                {
                    pagoTotal = horas * sueldoBase;
                }
                Console.WriteLine("El pago total de " + nombres[i] + " es de: Q" + pagoTotal);
            }
        }
    }
} 

