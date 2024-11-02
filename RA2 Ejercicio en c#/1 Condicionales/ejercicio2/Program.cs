using System;

class CalculoDescuento
{
    static void Main()
    {
        // Solicitar el precio del artículo
        Console.WriteLine("Introduce el precio del artículo:");
        decimal precio = decimal.Parse(Console.ReadLine());

        // Declarar variable para el descuento
        decimal porcentajeDescuento = 0;

        // Aplicar descuento según la escala de precios
        if (precio >= 1000 && precio <= 5000)
        {
            porcentajeDescuento = 0.03m; // 3% de descuento
        }
        else if (precio >= 5001 && precio <= 10000)
        {
            porcentajeDescuento = 0.05m; // 5% de descuento
        }
        else if (precio >= 10001 && precio <= 15000)
        {
            porcentajeDescuento = 0.08m; // 8% de descuento
        }
        else if (precio >= 15001 && precio <= 20000)
        {
            porcentajeDescuento = 0.10m; // 10% de descuento
        }
        else
        {
            Console.WriteLine("No hay descuento disponible para este precio.");
            return;
        }

        // Calcular el descuento
        decimal descuento = precio * porcentajeDescuento;

        // Calcular el precio final
        decimal precioFinal = precio - descuento;

        // Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Precio original: " + precio.ToString("C"));
        Console.WriteLine("Descuento aplicado (" + (porcentajeDescuento * 100) + "%): " + descuento.ToString("C"));
        Console.WriteLine("Precio final: " + precioFinal.ToString("C"));
    }
}
