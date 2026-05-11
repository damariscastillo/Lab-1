using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___PINZONCASTILLODAMARISAZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 01 - Ejemplo
            Console.WriteLine(" ---- EJERCICIO 01 ---- ");
            //crear las cuentas bancarias
            Console.WriteLine("  SALDO INICIAL  ");
            CuentaBancaria bac = new CuentaBancaria("Alejandro Castillo", "1284627", 100.00);
            CuentaBancaria promerica = new CuentaBancaria("Maria Rodriguez", "1284628", 100.00);
            //mostrar saldo inicial
            bac.Mostrar_Informacion();
            promerica.Mostrar_Informacion();

            //depositar cuenta 1
            Console.WriteLine();
            Console.WriteLine(" DEPOSITAR CUENTA 1 ");
            bac.Depositar(500);
            Console.WriteLine("--------------------------------------------------------");
            //retirar cuenta 2
            Console.WriteLine();
            Console.WriteLine(" RETIRAR CUENTA 2 ");
            promerica.Retirar(15000.00);
            promerica.Retirar(50);
            Console.WriteLine("--------------------------------------------------------");

            //mostrar saldo final
            Console.WriteLine();
            Console.WriteLine("  SALDO FINAL  ");
            bac.Mostrar_Informacion();
            promerica.Mostrar_Informacion();


            //ejercicio 02 - clase producto
            Console.WriteLine();
            Console.WriteLine(" ---- EJERCICIO 02 ---- ");
            //estado inicial - primero irá el nombre del producto, su precio y la cantidad que hay
            Productos producto1 = new Productos("Dona de Glaseada", 7.50, 24);
            Productos producto2 = new Productos("Café Frío", 12.00, 15);
            producto1.MostrarInformacion();
            Console.WriteLine();
            producto2.MostrarInformacion();

            //venta
            Console.WriteLine();
            producto1.Vender(5);
            Console.WriteLine();
            //reabastecimiento
            producto2.Reabastecer(12);

            //mostrar los cambios
            Console.WriteLine();
            Console.WriteLine("-- Estado actualizado --");
            producto1.MostrarInformacion();
            Console.WriteLine();
            producto2.MostrarInformacion();
            Console.WriteLine();

            //EJERCICIO 03
            Console.WriteLine(" ---- EJERCICIO 03 ---- ");
            //areglos
            double[] notasEstudiante1 = { 75, 80, 90, 65, 95, 75, 95 };
            double[] notasEstudiante2 = { 50, 45, 60, 70, 60, 55 };

            //objetos nombre . edad, grado(carrera). arreglo notas
            Estudiante estudiante1 = new Estudiante("Sophia García", 19, "Derecho ", notasEstudiante1);
            Estudiante estudiante2 = new Estudiante("Mathias Hernández", 21, "Gastronomía ", notasEstudiante2);
            Console.WriteLine();
            Console.WriteLine(" -- INFORMACIÓN -- ");
            // Estudiante 1
            estudiante1.MostrarInformación();
            estudiante1.Aprobar();
            Console.WriteLine();
            // Estudiante 2
            estudiante2.MostrarInformación();
            estudiante2.Aprobar();

            //agregar nueva nota
            Console.WriteLine();
            Console.WriteLine(" -- NUEVA NOTA -- ");
            estudiante2.AgregarNota(95);
            Console.WriteLine();
            Console.WriteLine(" Nueva nota agregada");
            estudiante2.MostrarInformación();
            estudiante2.Aprobar();
        }
    }
}
