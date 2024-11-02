using System;

class Program
{
    static void Main()
    {
        decimal[] produccion = new decimal[5];
        decimal totalProduccion = 0;
        decimal promedioProduccion;
        decimal incentivo = 0;

        Console.WriteLine("Ingrese la producción diaria desde el lunes hasta el viernes:");

        // Registrando la producción diaria y calculando el total
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Producción del día {i + 1}: ");
            produccion[i] = Convert.ToDecimal(Console.ReadLine());
            totalProduccion += produccion[i];
        }

        // Calcular el promedio de la producción
        promedioProduccion = totalProduccion / 5;

        // Determinando si le corresponde incentivo
        if (promedioProduccion >= 20000)
        {
            incentivo = 3000;
        }
        else
        {
            Console.WriteLine("Incentivo: N/A");
        }

        // Mostrar los resultados
        Console.WriteLine($"\nTotal de producción semanal: {totalProduccion:N0}");
        Console.WriteLine($"Promedio de producción diaria: {promedioProduccion:N0}");
        Console.WriteLine($"Incentivo: {(incentivo > 0 ? $"RD${incentivo:N0}" : "N/A")}");
    }
}
