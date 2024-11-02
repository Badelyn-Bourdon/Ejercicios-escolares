using System;

class CalculoImporte
{
    static void Main()
    {
        // Solicitar la cantidad de artículos
        Console.WriteLine("Introduce la cantidad de artículos:");
        int cantidad = int.Parse(Console.ReadLine());

        // Solicitar el precio por artículo
        Console.WriteLine("Introduce el precio por artículo:");
        decimal precio = decimal.Parse(Console.ReadLine());

        // Calcular el importe total
        decimal importe = cantidad * precio;

        // Mostrar el resultado
        Console.WriteLine("\nEl importe total es: " + importe.ToString("C"));
    }
}
