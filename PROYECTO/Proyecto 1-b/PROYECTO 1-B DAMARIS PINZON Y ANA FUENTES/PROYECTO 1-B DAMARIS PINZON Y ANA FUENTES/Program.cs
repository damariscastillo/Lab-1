using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_1_B_DAMARIS_PINZON_Y_ANA_FUENTES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INICIO DEL SISTEMA

            // Variables generales del sistema de parqueo
            string nombreOperador;
            string codigoTurno;
            string placa = "";
            string nombreCliente = "";

            int capacidad;
            int tipoVehiculo = 0;

            int ticketsCreados = 0;
            int ticketsCerrados = 0;

            // Control del tiempo simulado (en minutos)
            int tiempoActual = 0;
            int minutoEntrada = 0;
            int minutosSimulados = 0;

            // Variables para cálculos
            double horas = 0;
            double minutosEstacionado = 0;
            double tarifa = 0;
            double total = 0;
            double dineroRecaudado = 0;

            // Control del estado del sistema
            bool ticketActivo = false;
            bool clienteVIP = false;
            bool sistemaActivo = true;

            char opcion = ' ';

            // INGRESO DE DATOS INICIALES
            Console.Write("Ingrese nombre del operador: ");
            nombreOperador = Console.ReadLine();

            Console.Write("Ingrese codigo de turno (4 caracteres): ");
            codigoTurno = Console.ReadLine();

            // VALIDACIÓN: código debe tener exactamente 4 caracteres
            while (codigoTurno.Length != 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: El codigo debe tener 4 caracteres");
                Console.ResetColor();
                codigoTurno = Console.ReadLine();
            }
            // VALIDACIÓN: código debe ser entero
            Console.Write("Ingrese capacidad del parqueo (minimo 10): ");
            while (!int.TryParse(Console.ReadLine(), out capacidad))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Capacidad debe ser un entero");
                Console.ResetColor();
            }

            // VALIDACIÓN: capacidad mínima 10
            while (capacidad < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Capacidad minima es 10");
                Console.ResetColor();
                capacidad = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            // MENÚ PRINCIPAL (BUCLE)
            // Se repite hasta que el usuario elija salir
            while (sistemaActivo == true)
            {
                // Uso de color CYAN para resaltar el menú
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" -------MENU------- ");
                Console.WriteLine("A. Crear ticket");
                Console.WriteLine("B. Registrar salida");
                Console.WriteLine("C. Ver estado del parqueo");
                Console.WriteLine("D. Simular paso del tiempo");
                Console.WriteLine("E. Salir");
                Console.ResetColor();

                opcion = Convert.ToChar(Console.ReadLine().ToUpper());

                // VALIDACIÓN de opción ingresada
                while (opcion < 'A' || opcion > 'E')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Opcion invalida. Debe ingresar A, B, C, D o E.");
                    Console.ResetColor();
                    opcion = Convert.ToChar(Console.ReadLine().ToUpper());
                }

                Console.WriteLine();

                // A. CREAR TICKET
                if (opcion == 'A')
                {
                    // VALIDACIÓN: solo un ticket activo a la vez
                    if (ticketActivo == true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Ya existe un ticket activo");
                        Console.ResetColor();
                    }
                    else
                    {
                        // Selección del tipo de vehículo
                        Console.WriteLine("Tipo de vehiculo:");
                        Console.WriteLine("1 Moto");
                        Console.WriteLine("2 Carro");
                        Console.WriteLine("3 Pickup");
                        tipoVehiculo = Convert.ToInt32(Console.ReadLine());

                        // VALIDACIÓN del tipo de vehículo 1, 2 o 3
                        while (tipoVehiculo != 1 && tipoVehiculo != 2 && tipoVehiculo != 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Debe seleccionar un tipo de vehiculo valido (1, 2 o 3)");
                            Console.ResetColor();
                            tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                        }

                        bool placaValida = false;

                        Console.WriteLine();

                        // VALIDACIÓN DE PLACA

                        // EL formato debe ser: Letra mayúscula + guión + 3 números + 3 letras
                        while (placaValida == false)
                        {
                            Console.Write("Ingrese placa (Ejemplo: Moto: M-123ABC, Carro: O-123ABC o P-123ABC y Pickup: O-123ABC o P-123ABC): ");
                            placa = Console.ReadLine();

                            if (placa.Length == 8)
                            {
                                char letraInicial = placa[0];
                                char guion = placa[1];

                                bool numeros =
                                    char.IsDigit(placa[2]) &&
                                    char.IsDigit(placa[3]) &&
                                    char.IsDigit(placa[4]);

                                bool letras =
                                    char.IsUpper(placa[5]) &&
                                    char.IsUpper(placa[6]) &&
                                    char.IsUpper(placa[7]);

                                // Validación de estructura
                                if (guion == '-' && numeros && letras)
                                {
                                    // Validación según tipo de vehículo
                                    if (tipoVehiculo == 1 && letraInicial == 'M')
                                        placaValida = true;

                                    if ((tipoVehiculo == 2 || tipoVehiculo == 3) &&
                                        (letraInicial == 'O' || letraInicial == 'P'))
                                        placaValida = true;
                                }
                            }

                            // Mensaje de error en rojo
                            if (placaValida == false)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Placa invalida. Ejemplo: Moto: M-123ABC, Carro: O-123ABC o P-123ABC y Pickup: O-123ABC o P-123ABC");
                                Console.ResetColor();
                            }
                        }
                        // Ingreso del nombre del cliente y si es VIP
                        Console.Write("Ingrese nombre del cliente: ");
                        nombreCliente = Console.ReadLine();

                        Console.Write("Cliente VIP? (1=SI 0=NO): ");
                        int vip = Convert.ToInt32(Console.ReadLine());

                        // VALIDACIÓN de ingreso VIP (1 o 0)
                        while (vip != 0 && vip != 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Debe ingresar 1 para VIP o 0 para no VIP");
                            Console.ResetColor();
                            vip = Convert.ToInt32(Console.ReadLine());
                        }

                        clienteVIP = vip == 1;

                        // Registro del momento de entrada
                        minutoEntrada = tiempoActual;

                        ticketActivo = true;
                        ticketsCreados++;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ticket creado correctamente.");
                        Console.ResetColor();
                    }
                }

                // B. REGISTRAR SALIDA
                if (opcion == 'B')
                {
                    if (ticketActivo == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: No existe ticket activo");
                        Console.ResetColor();
                    }
                    else
                    {
                        // CÁLCULO DEL TIEMPO ESTACIONADO
                        minutosEstacionado = tiempoActual - minutoEntrada;

                        // ADVERTENCIAS (color amarillo)
                        if (minutosEstacionado > 360 && minutosEstacionado <= 720)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Advertencia: multa próxima por superar 6 horas.");
                            Console.ResetColor();
                        }

                        if (minutosEstacionado > 720)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Advertencia: permanencia extrema mayor a 12 horas.");
                            Console.ResetColor();
                        }

                        total = 0;

                        // TARIFAS SEGÚN VEHÍCULO
                        if (tipoVehiculo == 1) tarifa = 5;
                        if (tipoVehiculo == 2) tarifa = 10;
                        if (tipoVehiculo == 3) tarifa = 15;

                        // Conversión a horas
                        horas = (minutosEstacionado / 60);

                        // TARIFA BASE
                        if (minutosEstacionado <= 15)
                            total = 0; // gratis
                        else
                            //Ecuacion
                            total = horas * tarifa;

                        // MULTA por más de 6 horas
                        if (minutosEstacionado > 360)
                            total = total + 25;

                        // DESCUENTO VIP (10%)
                        if (clienteVIP == true)
                            total = total - (total * 0.10);

                        // RECARGO por más de 12 horas (20%)
                        if (minutosEstacionado > 720)
                        {
                            total = total + (total * 0.20);

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Se aplicó recargo por permanencia prolongada.");
                            Console.ResetColor();
                        }

                        // Actualización de estadísticas
                        dineroRecaudado = dineroRecaudado + total;
                        ticketsCerrados++;
                        ticketActivo = false;

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Tiempo estacionado: " + minutosEstacionado + " minutos");
                        Console.WriteLine("Monto a pagar: Q" + total);
                        Console.ResetColor();
                    }
                }


                // C. ESTADO DEL PARQUEO
                if (opcion == 'C')
                {
                    Console.WriteLine(" -------ESTADO DEL PARQUEO------- ");

                    Console.WriteLine("Capacidad total: " + capacidad);

                    // Lógica de ocupación
                    if (ticketActivo)
                    {
                        Console.WriteLine("Espacios ocupados: 1");
                        Console.WriteLine("Espacios disponibles: " + (capacidad - 1));
                    }
                    else
                    {
                        Console.WriteLine("Espacios ocupados: 0");
                        Console.WriteLine("Espacios disponibles: " + capacidad);
                    }

                    // Muestra del estado actual del sistema
                    Console.WriteLine("Tiempo simulado: " + tiempoActual + " minutos");
                    Console.WriteLine("Total recaudado: Q" + dineroRecaudado);
                    Console.WriteLine("Tickets creados: " + ticketsCreados);
                    Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                }

                // D. SIMULACIÓN DE TIEMPO  
                if (opcion == 'D')
                {
                    // Solicitud de minutos a simular
                    Console.Write("Ingrese minutos a simular (1 a 1440): ");
                    // VALIDACIÓN de ingreso numérico
                    while (!int.TryParse(Console.ReadLine(), out minutosSimulados))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Minutos a simular deben ser un entero");
                        Console.ResetColor();
                    }

                    // VALIDACIÓN del rango permitido
                    while (minutosSimulados < 1 || minutosSimulados > 1440)
                    {
                        Console.WriteLine("ERROR: Debe ingresar entre 1 y 1440 minutos.");
                        minutosSimulados = Convert.ToInt32(Console.ReadLine());
                    }

                    // Actualización del tiempo
                    tiempoActual = tiempoActual + minutosSimulados;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tiempo acumulado: " + tiempoActual + " minutos.");
                    Console.ResetColor();
                }


                // E. SALIR DEL SISTEMA
                if (opcion == 'E')
                {
                    // Uso de color amarillo al confirmar el resumen final
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    // RESUMEN FINAL DEL SISTEMA
                    Console.WriteLine(" -------RESUMEN FINAL------- ");
                    Console.WriteLine("Operador: " + nombreOperador);
                    Console.WriteLine("Tickets creados: " + ticketsCreados);
                    Console.WriteLine("Tickets cerrados: " + ticketsCerrados);
                    Console.WriteLine("Total recaudado: Q" + dineroRecaudado);
                    Console.WriteLine("Tiempo simulado total: " + tiempoActual + " minutos");

                    Console.ResetColor();

                    sistemaActivo = false;
                }
                Console.WriteLine();
            }
        }
    }
}
