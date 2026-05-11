using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___PINZONCASTILLODAMARISAZUCENA_1188926
{
    internal class CuentaBancaria
    {
        double saldo;
        string titular;
        string numeroCuenta;
        //constructor
        public CuentaBancaria(string nombreIngresado, string numeroCuentaGenerado, double saldoInicial)
        {
            this.titular = nombreIngresado;
            this.numeroCuenta = numeroCuentaGenerado; 
            this.saldo = saldoInicial;
        }

        //Métodos
        //Mostrar info
        public void Mostrar_Informacion()
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Cuenta: " + numeroCuenta.ToString() + " - " + titular);
            Console.WriteLine("Saldo: " + saldo.ToString());
            Console.WriteLine("--------------------------------------------------------");
        }
        
        //Depositar
        public void Depositar (double monto)
        {
            this.saldo += monto;
            Console.WriteLine("Se han depositado: Q" + monto);
        }
       
        //Retirar
        public void Retirar(double monto)
        { 
            if (saldo >= monto)
            {
                this.saldo = saldo - monto;
                Console.WriteLine();
                Console.WriteLine("El retiro de Q" + monto + " completado exitosamente. ");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Error: No se pudo completar la transaccion de Q" + monto + " Fondos insuficientes.");
            }
        }
    }
}
