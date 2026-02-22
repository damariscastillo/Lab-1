using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace L5__PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desafio 1: Estructuras selectivas
            //SALIDA
            Console.WriteLine("Desafío # 1: Estructuras Selectivas");
            Console.Write("Ingresar un numero entero ");
            //ENTRADA //PROCESO: CONVERSION
            double num = Convert.ToDouble(Console.ReadLine());
            //PROCESO
            if (num > 0)
            //SALIDA
            { Console.WriteLine("El numero " + num + " es positivo"); }
            else if (num < 0)
            //SALIDA
            { Console.WriteLine("El numero " + num + " es negativo"); }
            else
            //SALIDA
            { Console.WriteLine("El numero " + num + " es cero "); }
            Console.WriteLine();

            //Desafio 2:Estructuras selectivas
            //SALIDA
            Console.WriteLine("Desafio # 2: Estructuras Selectivas ");
            Console.Write("Ingresar año ");
            //ENTRADA
            string fecha = Console.ReadLine();
            //PROCESO
            if (int.TryParse(fecha, out int anno))
                if ((anno % 4 == 0 && anno % 100 != 0) || (anno % 400 == 0))
                //SALIDA
                { Console.WriteLine("El año " + anno + " Es bisiesto "); }
                else
                //SALIDA
                { Console.WriteLine("El año " + anno + " no es bisiesto "); }
            Console.WriteLine();

            //Desafio 3: Estructuras selectivas4
            Console.WriteLine("Desafio # 3: Estructuras Selectivas");
            //ENTRADAS
            Console.Write("Ingrese su ingreso mensual: Q ");
            double ingreso = double.Parse(Console.ReadLine());
            Console.Write("¿Tiene multa? (true/false): ");
            bool multa = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            double arbitrio = 0;
            //PROCESO
            if (ingreso >= 500.01 && ingreso <= 1000.00)
            { arbitrio = 10; }
            else if (ingreso >= 1000.01 && ingreso <= 3000.00)
            { arbitrio = 15; }
            else if (ingreso >= 3000.01 && ingreso <= 6000.00)
            { arbitrio = 50; }
            else if (ingreso >= 6000.01 && ingreso <= 9000.00)
            { arbitrio = 75; }
            else if (ingreso >= 9000.01 && ingreso <= 12000.00)
            { arbitrio = 100; }
            else if (ingreso >= 12000.01)
            { arbitrio = 150; }
            if (multa == true)
            { arbitrio = (arbitrio * 2);
                //Salida
                Console.WriteLine("Se aplicó la multa "); }
            Console.WriteLine("El monto a pagar por boleto de ornato es de: Q " + arbitrio);
            Console.WriteLine();

            //Desafio 4: Estructuras selectivas & Operadores aritméticos
            Console.WriteLine("Desafio #4: Estructuras selectivas & Operadores aritméticos ");
            //ENTRADA
            Console.WriteLine(" MÁQUINA DE PAGO DE PARQUEO ");
            Console.Write("Ingrese la cantidad de horas estacionado: ");
            int vuelto;
            int horas = int.Parse(Console.ReadLine());
            int totalAPagar = horas * 10;
            Console.WriteLine("Total a pagar: Q " + totalAPagar);
            Console.Write("Ingrese el monto a pagar: Q ");
            int clientePago = int.Parse(Console.ReadLine());
            //PROCESO
            if (clientePago < totalAPagar)
                //SALIDA
                Console.WriteLine("Error: El monto ingresado es insuficiente.");
            else if (clientePago == totalAPagar)
            //SALIDA
            { Console.WriteLine("Pago realizado. No se requiere cambio. ¡Feliz día!"); }
            else
            {    //PROCESO
                vuelto = clientePago - totalAPagar;
                Console.WriteLine("Su vuelto es de Q " + vuelto);
                int b100 = vuelto / 100;
                vuelto = vuelto % 100;
                int b50 = vuelto / 50;
                vuelto = vuelto % 50;
                int b20 = vuelto / 20;
                vuelto = vuelto % 20;
                int b10 = vuelto / 10;
                vuelto = vuelto % 10;
                int b5 = vuelto / 5;
                vuelto = vuelto % 5;
                int b1 = vuelto / 1;
                //SALIDA
                Console.WriteLine("Billetes entregados:");
                Console.WriteLine("Q100: " + b100);
                Console.WriteLine("Q50: " + b50);
                Console.WriteLine("Q20: " + b20);
                Console.WriteLine("Q10: " + b10);
                Console.WriteLine("Q5: " + b5);
                Console.WriteLine("Q1: " + b1);
            }
        }
    }
}
