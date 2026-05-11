using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L14___PINZONCASTILLODAMARISAZUCENA_1188926
{
    internal class Estudiante
    {
        string nombre;
        int edad;
        string grado;
        //Arreglo
        double[] notas;
        //constructor
        public Estudiante(string nombre, int edad, string grado, double[] notasIniciales) 
        {
            this.nombre = nombre;
            this.edad = edad;
            this.grado = grado;
            this.notas = notasIniciales; 
        }

        //metodos
        //calcular el promedio
        public double CalcularPromedio()
        {
            double suma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                suma = suma + notas[i];
            }

            if (notas.Length > 0)
            {
                return suma / notas.Length;
            }
            return 0;
        }
        //mostrar datos calculados
        public void MostrarInformación()
        {
            double prom = CalcularPromedio();
            Console.WriteLine("Estudiante: " + nombre);
            Console.WriteLine("Edad: " + edad );
            Console.WriteLine("Grado: " + grado);
            Console.WriteLine("Promedio: " + prom);
        }
        //indica si el estudiante aprobó
        public void Aprobar()
        {
            if (CalcularPromedio() >= 61)
            {
                Console.WriteLine(nombre + ": APROBADO");
            }
            else
            {
                Console.WriteLine(nombre + ": REPROBADO");
            }
        }

        //para agregar la nota nueva
        public void AgregarNota(double nuevaNota)
        {
            double[] nuevan = new double[notas.Length + 1];
            for (int i = 0; i < notas.Length; i++)
            {
                nuevan[i] = notas[i];
            }
            nuevan[nuevan.Length - 1] = nuevaNota;
            this.notas = nuevan;
            Console.WriteLine("Nota de " + nuevaNota + " agregada correctamente a " + nombre);
        }
       
    }
}
