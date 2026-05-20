using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_2_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" - PROYECTO DE LABORATORIO NO.02 - ");
            //Variables de configuración
            double caja, capitalInicial, sueldoMensual;
            int cantEmpleados, mesesTotales, totalFilas, totalCols;

            //Variables de inventario
            int cTrigo = 0, cRep = 0, cTom = 0, cCal = 0, cEsp = 0;
            double totalMatPrima = 0;

            //Variables de proceso
            int mesesRestantes, mesesSimuladosEfec = 0;
            string op;
            bool salir = false;
            double CostosMenProyectados, utilidadCalculada;

            //Variables de reporte
            double totalIngresoCosechas = 0, manodObratotal = 0,invproceso = 0, utilidadesFinales = 0;

            //Configuración Inicial
            Console.WriteLine("--- GESTIÓN DE LA GRANJA ---");
            Console.WriteLine("----------------------------------------");
            Console.Write("Dinero inicial: Q");
            caja = double.Parse(Console.ReadLine());
            capitalInicial = caja;

            Console.Write("Número de empleados: ");
            cantEmpleados = int.Parse(Console.ReadLine());

            Console.Write("Sueldo mensual por empleado: Q");
            sueldoMensual = double.Parse(Console.ReadLine());

            Console.Write("Meses por simular: ");
            mesesTotales = int.Parse(Console.ReadLine());
            mesesRestantes = mesesTotales;

            Console.Write("Cantidad de filas de la parcela: "); 
            totalFilas = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de columnas de la parcela: ");
            totalCols = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            //Matriz 
            Parcela[,] matrizParcelas = new Parcela[totalFilas, totalCols];
            for (int f = 0; f < totalFilas; f++)
            {
                for (int c = 0; c < totalCols; c++)
                {
                    matrizParcelas[f, c] = new Parcela();
                    matrizParcelas[f, c].Siembra = "Vacía";
                }
            }

            //Menu - ciclo
            while (mesesRestantes > 0 && caja > 0 && !salir)
            {
                Console.WriteLine();
                Console.WriteLine("Meses restantes: " + mesesRestantes);
                Console.WriteLine("Caja: Q" + caja);
                Console.WriteLine();
                Console.WriteLine(" -- MENÚ --");
                Console.WriteLine("1. Comprar Semillas");
                Console.WriteLine("2. Sembrar");
                Console.WriteLine("3. Consultar parcelas");
                Console.WriteLine("4. Avanzar de mes");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                op = Console.ReadLine();
                Console.WriteLine();

                switch (op)
                {
                    case "1":
                        CostosMenProyectados = cantEmpleados * sueldoMensual;
                        utilidadCalculada = caja - CostosMenProyectados;
                        Console.WriteLine("----------------------------------------");
                        Console.WriteLine("Caja: Q" + caja);
                        Console.WriteLine("Costos fijos: Q" + CostosMenProyectados);
                        Console.WriteLine("Utilidad: Q" + utilidadCalculada); Console.WriteLine();
                        Console.WriteLine("----------------------------------------");
                        if (utilidadCalculada >= 0)
                        {
                            Console.WriteLine("1.Trigo(Q100) 2.Repollo(Q180) 3.Tomate(Q250) 4.Calabaza(Q220) 5.Espárrago(Q500)");
                            Console.Write("Seleccione el tipo de semilla: ");
                            int tipo = int.Parse(Console.ReadLine());

                            //VALIDA QUE EL USUARIO SOLO INGRESE LAS OPCIONES DE SEMILLAS CORRECTAS
                            if (tipo >= 1 && tipo <= 5)
                            {
                                Console.Write("Cantidad: ");
                                int cantCompra = int.Parse(Console.ReadLine());

                                double precio = 0;
                                switch (tipo)
                                {
                                    case 1: precio = 100; break;
                                    case 2: precio = 180; break;
                                    case 3: precio = 250; break;
                                    case 4: precio = 220; break;
                                    case 5: precio = 500; break;
                                }

                                if (caja >= (precio * cantCompra))
                                {
                                    //restar el costo total de una compra al dinero que en caja
                                    caja -= (precio * cantCompra);

                                    //acumula el gasto total realizado en insumos (costos de producción.).
                                    totalMatPrima += (precio * cantCompra);
                                    if (tipo == 1) cTrigo += cantCompra;
                                    else if (tipo == 2) cRep += cantCompra;
                                    else if (tipo == 3) cTom += cantCompra;
                                    else if (tipo == 4) cCal += cantCompra;
                                    else if (tipo == 5) cEsp += cantCompra;

                                    Console.WriteLine("Compra exitosa.");
                                    Console.WriteLine();
                                }
                                else
                                {
                                    Console.WriteLine("No hay dinero suficiente en caja.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opción inválida: El tipo de semilla seleccionado no existe.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No puede comprar, utilidad negativa (debe asegurar sueldos).");
                        }
                        break;

                    //SEMBRAR
                    case "2":
                        Console.WriteLine("Inventario: Trigo: " + cTrigo + " | Repollo: " + cRep + " | Tomate: " + cTom + " | Calabaza: " + cCal + " | Espárrago: " + cEsp);
                        Console.Write("Fila: "); int fS = int.Parse(Console.ReadLine());
                        Console.Write("Col: "); int cS = int.Parse(Console.ReadLine());
                        if (matrizParcelas[fS, cS].Siembra == "Vacía")
                        {
                            Console.WriteLine("¿Qué desea sembrar? (1.Trigo, 2.Rep, 3.Tom, 4.Cal, 5.Esp): ");
                            string s = Console.ReadLine();
                            //consulta de semillas

                            if (s == "1" && cTrigo > 0)
                            {
                                matrizParcelas[fS, cS].Siembra = "Trigo";
                                matrizParcelas[fS, cS].MesesCrecer = 1;
                                matrizParcelas[fS, cS].Icosecha = 130;
                                cTrigo = cTrigo -1;
                                Console.WriteLine("¡Trigo sembrado!");
                            }
                            else if (s == "2" && cRep > 0)
                            {
                                matrizParcelas[fS, cS].Siembra = "Repollo";
                                matrizParcelas[fS, cS].MesesCrecer = 2;
                                matrizParcelas[fS, cS].Icosecha = 280;
                                cRep = cRep -1;
                                Console.WriteLine("¡Repollo sembrado!");
                            }
                            else if (s == "3" && cTom > 0)
                            {
                                matrizParcelas[fS, cS].Siembra = "Tomate";
                                matrizParcelas[fS, cS].MesesCrecer = 3;
                                matrizParcelas[fS, cS].Icosecha = 450;
                                cTom = cTom -1;
                                Console.WriteLine("¡Tomate sembrado!");
                            }
                            else if (s == "4" && cCal > 0)
                            {
                                matrizParcelas[fS, cS].Siembra = "Calabaza";
                                matrizParcelas[fS, cS].MesesCrecer = 4;
                                matrizParcelas[fS, cS].Icosecha = 360;
                                cCal = cCal - 1;
                                Console.WriteLine("¡Calabaza sembrada!");
                            }
                            else if (s == "5" && cEsp > 0)
                            {
                                matrizParcelas[fS, cS].Siembra = "Espárrago";
                                matrizParcelas[fS, cS].MesesCrecer = 6;
                                matrizParcelas[fS, cS].Icosecha = 1000;
                                cEsp = cEsp - 1;
                                Console.WriteLine("¡Espárrago sembrado!");
                            }
                            else if (s != "1" && s != "2" && s != "3" && s != "4" && s != "5")
                            {
                                Console.WriteLine("OPCIÓN INVÁLIDA. Por favor, elija un número del 1 al 5.");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficientes semillas de ese tipo.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR: La parcela ya se encuentra ocupada.");
                        }
                        break;

                    //CONSULTAR PARCELAS
                    case "3":
                        Console.Write("Fila a consultar: ");
                        int fC = int.Parse(Console.ReadLine());
                        Console.Write("Col a consultar: ");
                        int cC = int.Parse(Console.ReadLine());
                        //validar
                        if (fC >= 0 && fC < totalFilas && cC >= 0 && cC < totalCols)
                        {
                            Parcela p = matrizParcelas[fC, cC];
                            if (p.Siembra != "Vacía")
                            {
                                Console.WriteLine("Posición: (" + fC + ", " + cC + ") | Estado: Ocupada");
                                Console.WriteLine("Cultivo: " + p.Siembra + " | Faltan: " + p.MesesCrecer + " meses | Ingreso: Q" + p.Icosecha);
                            }
                            else
                            {
                                Console.WriteLine("Posición: (" + fC + ", " + cC + ") | Estado: Libre");
                                Console.WriteLine("Ingresos esperados: Q0.00");

                            }
                            Console.WriteLine();
                            Console.WriteLine(" MAPA DE LA MATRIZ (PARCELA)");
                            for (int f = 0; f < totalFilas; f++)
                            {
                                for (int c = 0; c < totalCols; c++)
                                {
                                    string simbolo = " . ";
                                    if (matrizParcelas[f, c].Siembra == "Trigo") simbolo = " T ";
                                    else if (matrizParcelas[f, c].Siembra == "Repollo") simbolo = " R ";
                                    else if (matrizParcelas[f, c].Siembra == "Tomate") simbolo = " M ";
                                    else if (matrizParcelas[f, c].Siembra == "Calabaza") simbolo = " C ";
                                    else if (matrizParcelas[f, c].Siembra == "Espárrago") simbolo = " E ";
                                    Console.Write("[" + simbolo + "]");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("---------------------------------");
                            Console.WriteLine("(Significado: [ . ]=Vacía | [ T ]=Trigo | [ R ]=Repollo | [ M ]=Tomate | [ C ]=Calabaza | [ E ]=Espárrago)");
                        }
                        else
                        {
                            Console.WriteLine("ERROR: Esa posición no existe. La granja es más pequeña.");
                        }
                        break;

                    //AVANZAR DE MES
                    case "4":
                        //calcular GASTO EMPLEADOS
                        double sueldosMes = cantEmpleados * sueldoMensual;
                        //RESTAR DE LA CAJA
                        caja = caja - sueldosMes;
                        //sumar el mes al tiempo transucrrido
                        mesesSimuladosEfec = mesesSimuladosEfec + 1;
                        for (int f = 0; f < totalFilas; f++)
                        {
                            for (int c = 0; c < totalCols; c++)
                            {
                                //validar si está ocupada
                                if (matrizParcelas[f, c].Siembra != "Vacía")
                                {
                                    //restarle 1 al tiempo que falta
                                    matrizParcelas[f, c].MesesCrecer = matrizParcelas[f, c].MesesCrecer - 1;
                                    //llega a cero momento de cosechar
                                    if (matrizParcelas[f, c].MesesCrecer <= 0)
                                    {
                                        //sumar el valor de la cosecha
                                        caja = caja + matrizParcelas[f, c].Icosecha;
                                        totalIngresoCosechas = totalIngresoCosechas + matrizParcelas[f, c].Icosecha;

                                        Console.WriteLine("¡Cosecha en (" + f + "," + c + ")! +Q" + matrizParcelas[f, c].Icosecha);
                                        // REINICIAR PARCELA
                                        matrizParcelas[f, c] = new Parcela();
                                        matrizParcelas[f, c].Siembra = "Vacía";
                                    }
                                }
                            }
                        }
                        Console.WriteLine(" --- RESUMEN DEL MES " + mesesSimuladosEfec + " --- ");
                        Console.WriteLine("Salarios devengados este mes: Q" + sueldosMes);
                        Console.WriteLine("Dinero restante en caja: Q" + caja);
                        break;

                    //SALIR
                    case "5":
                        salir = true;
                        break;
                }
            }

            if (caja <= 0)
            {
                Console.WriteLine("¡ALERTA! La granja se ha quedado sin dinero en caja.");
            }
            invproceso = 0;
            for (int f = 0; f < totalFilas; f++)
            {
                for (int c = 0; c < totalCols; c++)
                {
                    if (matrizParcelas[f, c].Siembra != "Vacía")
                    {
                        invproceso = invproceso + matrizParcelas[f, c].Icosecha;
                    }
                }
            }
            //calculo mano de obra
            manodObratotal = cantEmpleados * sueldoMensual * mesesSimuladosEfec;
            //Calculo de las utilidades finales
            utilidadesFinales = capitalInicial + totalIngresoCosechas - manodObratotal - totalMatPrima;
            Console.WriteLine();
            Console.WriteLine(" ----------------------------------------------");
            Console.WriteLine("   - REPORTE FINAL -   ");
            Console.WriteLine(" ----------------------------------------------");
            Console.WriteLine(" Capital Inicial: Q" + capitalInicial);
            Console.WriteLine(" Ingresos por Cosechas: Q" + totalIngresoCosechas);
            Console.WriteLine(" Inventario en Proceso: Q" + invproceso);
            Console.WriteLine(" Mano de Obra: Q" + manodObratotal);
            Console.WriteLine(" Materia Prima: Q" + totalMatPrima);
            Console.WriteLine(" Utilidades Finales: Q" + utilidadesFinales);
            Console.WriteLine(" ----------------------------------------------");

        }
    }
}

