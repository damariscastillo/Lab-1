using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15___PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. SEGUIMIENTO PASO A PASO (DEBUGGING)
            Console.WriteLine();
            Console.WriteLine(" - EJERCICIO # 03 - ");
            Console.WriteLine(" SEGUIMIENTO PASO A PASO (DEBUGGING) ");

            double capital = 1000;
            double tasa = 0.05;
            double intereses = 0;
            double abonos = 0;
            for (int mes = 1; mes <= 12 && capital > 0; mes++)
            {
                //calculo intereses del mes
                intereses = capital * tasa;

                //abono realizado cada mes
                abonos = 100 + (mes * 10);

                //actualizar el capital
                capital = capital + intereses - abonos;
            }


            // PRUEBAS DE CALIDAD - SERIE 02
            //Pruebas de calidad testing 
            Console.WriteLine(" PRUEBAS DE CALIDAD - TESTING ");
            Console.WriteLine();

            //Ejercicio 01 testing
            Console.WriteLine(" - EJERCICIO 01 - ");

            Console.Write("Ingrese el saldo de la cuenta: Q");
            double mSaldo = Convert.ToDouble(Console.ReadLine());
            if (mSaldo < 0)
            {
                Console.WriteLine(" Error: No se puede iniciar una cuenta con saldo negativo.");
                return;
            }
            Console.Write("Ingrese el monto que desea retirar: ");
            double montoret = Convert.ToDouble(Console.ReadLine());
            RetirarEfectivo(ref mSaldo, montoret);

            Console.WriteLine(" Saldo actualizado: " + mSaldo);
            Console.WriteLine();

            //Ejercicio 02 testing
            Console.WriteLine(" - EJERCICIO 02 - ");
            Console.Write("Ingrese el precio original del producto: ");
            double precioIngresado = Convert.ToDouble(Console.ReadLine());
            if (precioIngresado < 0)
            {
                Console.WriteLine(" Error: Precio negativo ");
                return;
            }
            Console.Write("Ingrese el porcentaje de descuento: ");
            double porcentajeIngresado = Convert.ToDouble(Console.ReadLine());
            double resultado = calcularDescuento(precioIngresado, porcentajeIngresado);
            Console.WriteLine();
            Console.WriteLine("Precio inicial: Q" + precioIngresado);
            Console.WriteLine("Descuento: " + porcentajeIngresado + "%");
            Console.WriteLine("Total a pagar: Q" + resultado);

            //ejercicio 03 - testing
            Console.WriteLine();
            Console.WriteLine(" - EJERCICIO 03 - ");
            Console.Write("Ingrese el saldo disponible: ");
            double saldoActual = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el monto a depositar: ");
            double montoDepositar = Convert.ToDouble(Console.ReadLine());
            if (saldoActual < 0 || montoDepositar <= 0)
            {
                Console.WriteLine("Error: No se puede procesar la transacción ");
            }
            else
            {
                Depositar(ref saldoActual, montoDepositar);
                Console.WriteLine("El saldo final es: " + saldoActual);
            }
        }


        //SERIE DOS

        //Ejercicio 01 - testing
        static void RetirarEfectivo(ref double saldo, double montoRetirado)
        {
            if (montoRetirado <= 0)
            { Console.WriteLine(" Error el retiro debe de ser mayor a 0 "); return; }
            if (montoRetirado > saldo)
            {
                Console.WriteLine(" Error:Fondos Insuficientes. "); return;
            }
            Console.WriteLine();
            saldo = saldo - montoRetirado;
            Console.WriteLine(" Retiro Exitoso.");
        }
        //Ejercicio 02 - testing
        static double calcularDescuento(double precio, double porcentaje)
        {

            if (porcentaje < 0)
            {
                Console.WriteLine(" Error: Descuento negativo. Se aplicará el 0% ");
                porcentaje = 0;
            }
            else if (porcentaje > 100)
            {
                Console.WriteLine(" Descuento mayor al 100%. Se aplicará un descuento de 100% ");
                porcentaje = 100;
            }

            double resultado = precio - (precio * porcentaje / 100);
            return resultado;
            //return precio - (precio * porcentaje / 100); 
        }

        //Ejercicio 03 - testing
        static void Depositar(ref double saldo, double monto)
        {

            saldo = saldo + monto;
        }
    }
}
    












