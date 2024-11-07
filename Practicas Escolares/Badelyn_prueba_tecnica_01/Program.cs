using System;

class ReservaAsientos
{
    static void Main()
    {
        // aqui defino una matriz de 10x10 para los asientos 
        char[,] asientos = new char[10, 10];

        // Inicialiso  todos los asientos como libres con la letra l
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                asientos[i, j] = 'l'; 
            }
        }

        // Menú de opciones 
        /*este menu de opciones mediante el tipo de dato bool
          muestra al usuario una serie de preguntas*/
        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            MostrarAsientos(asientos); 
            Console.WriteLine("\nBienvenid@ al sistema de reservas de asientos.");
            Console.WriteLine("1. Quiero Reservar un asiento");
            Console.WriteLine("2.salir");
            Console.Write("elije una opcion: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    // Si el suario ingreso 1 entonces el sistema hara estos procesos
                    Console.Write("Ingresa el número de fila (1-10): ");
                    int fila = int.Parse(Console.ReadLine()) - 0; // Restamos 1 para usar índices 0 a 9 y haci cada vez que elija otro

                    Console.Write("Ingresa el número de asiento (1-10): ");
                    int asiento = int.Parse(Console.ReadLine())  - 0; // Restamos 1 para usar índices 0 a 9

                    // ahoar verifico bueno el sistema  si el asiento está libre
                    if (fila >= 0 && fila < 10 && asiento >= 0 && asiento < 10)
                    {
                        if (asientos[fila, asiento] == 'l')
                        {
                            // Reservar el asiento
                            asientos[fila, asiento] = 'x'; // x para no disponible
                            Console.WriteLine("¡Asiento reservado con éxito!");
                        }
                        else
                        {
                            Console.WriteLine("Este asiento ya está ocupado.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Por favor, ingresa una fila y asiento válidos (1-10).");
                    }
                    break;

                case "2":
                    continuar = false;
                    Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intenta de nuevo.");
                    break;
            }

            // Pausar para ver la salida antes de continuar
            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

    // Método para mostrar el estado de los asientos
    static void MostrarAsientos(char[,] asientos)
    {
        Console.WriteLine("Estado de los asientos:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(asientos[i, j] + " " ); // Imprimir cada asiento
            }
            Console.WriteLine(); // Salto de línea después de cada fila
        }
    }
}
