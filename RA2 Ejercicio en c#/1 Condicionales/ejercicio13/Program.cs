using System;

class Program
{
    static void Main()
    {
        // Entrada del importe del artículo
        Console.WriteLine("Ingrese el importe del artículo:");
        decimal importe = Convert.ToDecimal(Console.ReadLine());

        // Calcular el ITBIS (18%)
        decimal itbis = importe * 0.18m;

        // Calcular el descuento (10%)
        decimal descuento = importe * 0.10m;

        // Calcular el total general
        decimal totalGeneral = (importe - descuento) + itbis;

        // Mostrar resultados
        Console.WriteLine($"\nImporte: RD${importe:N2}");
        Console.WriteLine($"ITBIS (18%): RD${itbis:N2}");
        Console.WriteLine($"Descuento (10%): RD${descuento:N2}");
        Console.WriteLine($"Total General: RD${totalGeneral:N2}");
    }
}
