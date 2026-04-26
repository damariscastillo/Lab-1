using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_PINZON_CASTILLO_DAMARIS_AZUCENA_1188926
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio 01
            Console.WriteLine("EJERCICIO # 01");
            Console.WriteLine(" - MATRIZ CUADRADA 5X5 - ");
            Console.WriteLine();
            int[,] matrizCuadrada = new int[5, 5];
            Llenar(matrizCuadrada);
            int sumaPrincipal = SumaDiagonalPrincipal(matrizCuadrada);
            int sumaSecundaria = SumaDiagonalSecundaria(matrizCuadrada);
            Console.WriteLine();
            Console.WriteLine("Suma diagonal principal: " + sumaPrincipal);
            Console.WriteLine("Suma diagonal secundaria: " + sumaSecundaria);

            //Ejercicio 02
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 02");
            Console.WriteLine("- CONTEO DE PARES E IMPARES -");
            int[,] matriz = new int[4, 6];
            llenar(matriz);
            int totalP = ContarPares(matriz);
            int totalI = ContarImpares(matriz);
            Console.WriteLine();
            Console.WriteLine("Cantidad de números pares: " + totalP);
            Console.WriteLine("Cantidad de números impares: " + totalI);

            //Ejercicio 03
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 03 ");
            Console.WriteLine(" - REGISTRO DE NOTAS - ");
            Console.WriteLine();
            float[,] notas = new float[5, 4];
            ingresarNotas(notas);
            for (int i = 0; i < 5; i++)
            {
                float prom = promedio(notas, i);
                bool resultado = aprueba(prom);
                string estado = "";
                if (resultado == true)
                {
                    estado = "Aprobado";
                }
                else
                {
                    estado = "Reprobado";
                }
                Console.WriteLine("Estudiante " + (i + 1) + " Promedio: " + prom + " Estado: " + estado);
            }

            //Ejercicio 04
            Console.WriteLine();
            Console.WriteLine("EJERCICIO # 04 ");
            Console.WriteLine(" - MATRIZ SIMÉTRICA - ");
            Console.WriteLine();
            int[,] matrizSimetrica = new int[3, 3];
            Llenarmatriz(matrizSimetrica);
            bool Simetrica = verificarS(matrizSimetrica);
            if (Simetrica == true)
            {
                Console.WriteLine("La matriz es simétrica.");
            }
            else
            {
                Console.WriteLine("La matriz no es simétrica.");
            }

        }
        //Ejercicio 01
        static void Llenar(int[,] m)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Ingrese los números[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }

            }
        }
        static int SumaDiagonalPrincipal(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                suma += m[i, i];
            }
            return suma;
        }
        static int SumaDiagonalSecundaria(int[,] m)
        {
            int suma = 0;
            for (int i = 0; i < 5; i++)
                suma += m[i, 4 - i];
            return suma;
        }
        //ejercicio 02
        static void llenar(int[,] m)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write($"Ingrese números[{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static int ContarPares(int[,] m)
        {
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (m[i, j] % 2 == 0)
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }
        static int ContarImpares(int[,] m)
        {
            int cont = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (m[i, j] % 2 != 0)
                    {
                        cont++;
                    }
                }
            }
            return cont;
        }

        //EJERCICIO 03
        static void ingresarNotas(float[,] m)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese las notas del estudiante " + (i + 1) + ":");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" Nota [" + j + "]:");
                    m[i, j] = float.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }

        static float promedio(float[,] m, int estudiante)
        {
            float suma = 0;
            for (int j = 0; j < 4; j++)
            {
                suma += m[estudiante, j];
            }
            return suma / 4;
        }
        static bool aprueba(float promedioEstudiante)
        {
            if (promedioEstudiante >= 61)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //EJERCICIO 04
        static void Llenarmatriz(int[,] m)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Ingrese valor [{i}, {j}]: ");
                    m[i,j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static bool verificarS(int[,] m)
        {
            int coincidencia = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (m[i, j] == m[j, i])
                    {
                         coincidencia++;
                    }
                }
            }
            if (coincidencia == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
