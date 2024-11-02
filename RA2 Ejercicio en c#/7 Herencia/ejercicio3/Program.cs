using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Seleccione el tipo de transporte:");
        Console.WriteLine("1. Bus Interurbano");
        Console.WriteLine("2. Taxi");
        Console.WriteLine("3. Metro");
        Console.WriteLine("4. Teleférico");
        Console.Write("Opción: ");
        int opcion = Convert.ToInt32(Console.ReadLine());

        // Entradas comunes
        Console.Write("Ingrese el destino: ");
        string destino = Console.ReadLine();

        Console.Write("Ingrese la distancia (en km): ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo estimado (en horas): ");
        double tiempo = Convert.ToDouble(Console.ReadLine());

        double costo = 0;

        // Calcular el costo según el tipo de transporte
        switch (opcion)
        {
            case 1: // Bus Interurbano
                costo = distancia * 10; // Ejemplo de costo por km
                Console.WriteLine($"Compañía de Bus: Interbus");
                break;

            case 2: // Taxi
                costo = distancia * 20; // Ejemplo de costo por km
                Console.WriteLine($"Corredor del Taxi: Centro");
                break;

            case 3: // Metro
                costo = 15; // Costo fijo
                Console.WriteLine($"Compañía de Metro: Metro de la Ciudad");
                break;

            case 4: // Teleférico
                costo = 25; // Costo fijo
                Console.WriteLine($"Compañía de Teleférico: Teleférico de la Montaña");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                return;
        }

        // Mostrar resultados
        Console.WriteLine($"\nDetalles del Transporte:");
        Console.WriteLine($"Destino: {destino}");
        Console.WriteLine($"Distancia: {distancia} km");
        Console.WriteLine($"Tiempo estimado: {tiempo} horas");
        Console.WriteLine($"Costo del Boleto: RD$ {costo}");
    }
}
