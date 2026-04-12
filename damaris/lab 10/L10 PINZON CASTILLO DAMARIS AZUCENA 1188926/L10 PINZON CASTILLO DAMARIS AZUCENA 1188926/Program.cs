using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L10_PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 01  - FUNCION - SUMA DE DIGITOS (PARÁMETRO POR VALOR)
            Console.WriteLine("EJERCICIO 01 - FUNCION PARÁMETRO VALOR");
            Console.Write("Ingrese un número entero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int suma = SumarDigitos(numero);
            Console.WriteLine("La suma de los dígitos es: " + suma);
            Console.WriteLine();

            //EJERCICIO 02 - Funcion - AJUSTE DE SALDO (PARÁMETRO POR REFERENCIAS)
            Console.WriteLine("EJERCICIO 02 - AJUSTE DE SALDO");
            Console.Write("Ingrese el saldo inicial de la cuenta: ");
            double miSaldo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el monto que desea retirar: ");
            double montoARetirar = Convert.ToDouble(Console.ReadLine());
            string mensajeResultado = AjustarSaldo(ref miSaldo, montoARetirar);
            Console.WriteLine();
            Console.WriteLine(mensajeResultado);
            Console.WriteLine("Saldo final: " + miSaldo);
            Console.WriteLine();

            //EJERCICIO 03. FUNCION  - SUMA DE DIGTOS (PARÁMETRO POR VALOR)
            Console.WriteLine("EJERCICIO 03 - INTEGRACION CONVERSION DE TERMPERATURA");
            Console.WriteLine("Ingrese temperatura en Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double resultadoFahrenheit = 0;
            string mensaje = Convertir(celsius, ref resultadoFahrenheit);
            Console.WriteLine();
            Console.WriteLine(mensaje);
            Console.WriteLine();

            //EJERICICIO 04. FUNCIONES - SISTEMA DE PUNTOS DE ESTUDIANTE.
            Console.WriteLine("EJERCICIO 04 - SISTEMA DE PUNTOS");
            Console.Write("Ingrese los puntos iniciales: ");
            int puntos = int.Parse(Console.ReadLine());
            bool sistemaActivo = true;
            Console.WriteLine();
            while (sistemaActivo)
            {
                Console.WriteLine(" - EJERCICIO 04: FUNCIONES - SISTEMA DE PUNTOS - ");
                Console.WriteLine("Menú de Opciones:");
                Console.WriteLine("1. Agregar 10 puntos");
                Console.WriteLine("2. Quitar 7 puntos");
                Console.WriteLine("3. Ver Nivel");
                Console.WriteLine("4. Evaluar Estado");
                Console.WriteLine("5. Salir");
                Console.WriteLine();
                Console.Write("Seleccione una opcion: ");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine();
                        int totalMas = agregarPuntos(ref puntos);
                        Console.WriteLine("Se agregaron 10 puntos. Total actual: " + totalMas);
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine();
                        int totalMenos = quitarPuntos(ref puntos);
                        Console.WriteLine("Se quitaron 7 puntos. Total actual: " + totalMenos);
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Nivel obtenido: " + obtenerNivel(puntos));
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Estado académico: " + evaluarEstado(puntos));
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Saliendo.");
                        sistemaActivo = false;
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine();
                        break;
                }
            }
        }

        //EJERCICIO 01  - FUNCION - SUMA DE DIGITOS (PARÁMETRO POR VALOR)
        static int SumarDigitos(int n)
        {
            int suma = 0;
            while (n > 0)
            {
                int ultimoDigito = n % 10;
                suma = suma + ultimoDigito;
                n = n / 10;
            }
            return suma;
        }

        //EJERCICIO 02 - Funcion - AJUSTE DE SALDO (PARÁMETRO POR REFERENCIAS)
        static string AjustarSaldo(ref double saldo, double monto)
        {
            if (monto <= saldo)
            {
                saldo -= monto;
                return "OPERACIÓN EXITOSA: El retiro se ha realizado";
            }
            else
            {
                return "OPERACIÓN RECHAZADA: Fondos insuficientes";
            }
        }

        //EJERCICIO 03. FUNCION  - SUMA DE DIGTOS (PARÁMETRO POR VALOR)
        static string Convertir(double c, ref double f)
        {
            f = (c * 9 / 5) + 32;
            return "La temperatura es: " + f + " °F";
        }

        //EJERCICIO 04 - SISTEMA DE PUNTOS DE ESTUDIANTE
        //4.1
        static int agregarPuntos(ref int p)
        {
            p += 10;
            if (p > 100) p = 100;
            return p;
        }
        //4.2
        static int quitarPuntos(ref int p)
        {
            p -= 7;
            if (p < 0) p = 0;
            return p;
        }
        //4.3
        static string obtenerNivel(int p)
        {
            if (p >= 80 && p <= 100)
            {
                return "Avanzado";
            }
            else if (p >= 50 && p <= 79)
            {
                return "Intermedio";
            }
            else
            {
                return "Básico";
            }
        }

        //4.4
        static string evaluarEstado(int p)
        {
            if (p == 100)
            {
                return "Excelente";
            }
            else if (p >= 70 && p <= 99)
            {
                return "Aprobado";
            }
            else if (p >= 1 && p <= 69)
            {
                return "Reprobado";
            }
            else
            {
                return "Puntos en cero";
            }
        }
        }
}
