using System;

class CalculoTotalArticulo
{
    static void Main()
    {
        // Solicitar la cantidad de artículos
        Console.WriteLine("Introduce la cantidad de artículos:");
        int cantidad = int.Parse(Console.ReadLine());

        // Solicitar el precio por artículo
        Console.WriteLine("Introduce el precio por artículo:");
        decimal precio = decimal.Parse(Console.ReadLine());

        // Calcular el importe
        decimal importe = cantidad * precio;

        // Calcular el ITBIS (18%)
        decimal itbis = importe * 0.18m;

        // Calcular el descuento (10%)
        decimal descuento = importe * 0.10m;

        // Calcular el total general
        decimal totalGeneral = (importe - descuento) + itbis;

        // Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Importe: " + importe.ToString("C"));
        Console.WriteLine("ITBIS (18%): " + itbis.ToString("C"));
        Console.WriteLine("Descuento (10%): " + descuento.ToString("C"));
        Console.WriteLine("Total General: " + totalGeneral.ToString("C"));
    }
}
