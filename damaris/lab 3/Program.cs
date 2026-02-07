using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Actividad1_Damaris_Pinzon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cual es tu nonmbre ? ");
            String name;
            name = Console.ReadLine();
            Console.WriteLine("Cual tu curso ");
            string curso;
            curso = Console.ReadLine();
            Console.WriteLine("Hola " + name);
            Console.WriteLine("Bienvenido al curso de " + curso);
            Console.WriteLine("Te deseo mucho exito en el curso que estas iniciando.");
            Console.WriteLine("Recuerda que con esfuerzo y dedicación podrás alcanzar todas tus metas. ");
            Console.WriteLine("No tengas miedo de equivocarte, porque cada error es parte del aprendizaje. ");
            Console.WriteLine("Sigue Adelante con entusiasmo y confianza en ti mismo. ");
            Console.WriteLine("Estoy segura de que lograras grandes cosas. ");
        }
    }
}
