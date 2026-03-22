using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace L9_DamarisAzucenaPinzonCastillo_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //parametros - Ejercicio 01
            Console.WriteLine("EJERCICIO 01 - PARÁMETROS");
            Console.WriteLine();
            Console.WriteLine("Ingrese la cadena: ");
            string palabra = Convert.ToString(Console.ReadLine());
            entrada(palabra);

            //parámetros por referencia - ejercicio 02.
            Console.WriteLine();
            Console.WriteLine("EJERCICIO 02 - PARÁMETROS POR REFERENCIA");
            Console.WriteLine();
            Console.WriteLine("Ingrese un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            valor(ref n1, n2);

            //Integración – Parámetros por valor y por referencia - ejercicio 03
            Console.WriteLine();
            Console.WriteLine("EJERCICIO 03 - PARÁMETROS POR VALOR Y POR REFERENCIA");
            double precio = 48.50;
            Console.WriteLine("El precio del boleto es de Q 48.50");
            Console.WriteLine("¿Tiene descuento? (Si/No):");
            string respuesta = Console.ReadLine();
            if (respuesta == "no" || respuesta == "NO" || respuesta == "No")
            {
                Console.WriteLine("El precio del boleto permanece igual: Q 48.50");
            }
            else if (respuesta == "si" || respuesta == "SI" || respuesta == "Si")
            {
                Console.WriteLine("Ingrese el porcentaje (niños 0.5, adultos 0.15, premium 0.9): ");
                double descuentoIngresado = double.Parse(Console.ReadLine());
                Console.WriteLine("Precio antes de aplicar descuento: Q " + precio);
                Descuento(descuentoIngresado, ref precio);
                Console.WriteLine();
                Console.WriteLine("Precio despues de aplicar descuento: Q " + precio);
            }
            else
            {
                Console.WriteLine("Invalido.");
            }


            //Videojuego - ejercicio 04
            Console.WriteLine();
            Console.WriteLine("EJERCICIO 04 - VIDEOJUEGO");
            int puntosSalud = 15;
            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine();
                Console.WriteLine("- MENÚ DE VIDEOJUEGO -");
                Console.WriteLine("1. Recibir Daño (-5 pts)");
                Console.WriteLine("2. Curar (+3 pts)");
                Console.WriteLine("3. Mostrar Estado de Salud (Color)");
                Console.WriteLine("4. Calificar Desempeño (Finalizar)");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                Console.WriteLine();
                switch (opcion)
                {
                    case "1":
                        recibirDaño(ref puntosSalud);
                        Console.WriteLine("¡Has recibido daño!");
                        break;
                    case "2":
                        curar(ref puntosSalud);
                        Console.WriteLine("Te has curado.");
                        break;
                    case "3":
                        mostrarSalud(puntosSalud);
                        break;
                    case "4":
                        calificarDesempeño(puntosSalud);
                        break;
                    case "5":
                        continuar = false;
                        break;
                }
            }
        }

            //parametros - Ejercicio 01
            static void entrada(string p)
            {
                Console.WriteLine("La cadena es de: " + p.Length);
            }

            //parámetros por referencia - ejercicio 02.
            static void valor(ref int num1, int num2)
            {
                int num3 = num1;
                num1 = num2;
                num2 = num3;
                Console.WriteLine();
                Console.WriteLine("El primer valor es: " + num1);
                Console.WriteLine("El segundo valor es: " + num2);
            }

            //Integración – Parámetros por valor y por referencia - ejercicio 03
            static void Descuento(double descuento, ref double precio)
            {
                switch (descuento)
                {
                    case 0.5:
                        Console.WriteLine("Tipo: Niños");
                        break;
                    case 0.15:
                        Console.WriteLine("Tipo: Adultos Mayores");
                        break;
                    case 0.9:
                        Console.WriteLine("Tipo: Membresía Premium");
                        break;
                    default:
                        Console.WriteLine("Categoría: Descuento no reconocido.");
                        break;
                }
                double descuentoCalculado = precio * descuento;
                precio = precio - descuentoCalculado;
            }
            static void recibirDaño(ref int salud)
            {
                salud -= 5;
                if (salud < 0)
                {
                    salud = 0;
                }
            }
            static void curar(ref int salud)
            {
                salud += 3;
                if (salud > 15)
                {
                    salud = 15;
                }
            }
            static void mostrarSalud(int salud)
            {
                Console.Write("Salud actual: ");

                if (salud >= 11 && salud <= 15)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (salud >= 6 && salud <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.WriteLine(salud + " pts");
                Console.ResetColor();
            }
            static void calificarDesempeño(int salud)
            {
                string calificacion = "";

                if (salud == 15) calificacion = "S";
                else if (salud >= 11) calificacion = "A";
                else if (salud >= 6) calificacion = "B";
                else if (salud >= 1) calificacion = "C";
                else calificacion = "F (Game Over)";
                Console.WriteLine();
                Console.WriteLine("La calificacion final es de: " + calificacion);
            }
        
    }
}

