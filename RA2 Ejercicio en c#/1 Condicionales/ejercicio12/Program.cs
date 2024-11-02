using System;

class Program
{
    static void Main()
    {
        // Entrada del sueldo
        Console.WriteLine("Ingrese el sueldo del empleado:");
        decimal sueldo = Convert.ToDecimal(Console.ReadLine());

        // Entrada de datos de cuanto hijos tiene
        Console.WriteLine("Ingrese el número de hijos:");
        int numeroHijos = Convert.ToInt32(Console.ReadLine());

        decimal incentivo = 0;

        // Calculando el incentivo si el empleado tiene hijos
        if (numeroHijos > 0)
        {
            incentivo = numeroHijos * 500;
        }

        // Mostrar resultado o la salida
        Console.WriteLine($"\nSueldo: RD${sueldo:N2}");
        Console.WriteLine($"Número de hijos: {numeroHijos}");
        Console.WriteLine($"Incentivo: {(numeroHijos > 0 ? $"RD${incentivo:N2}" : "N/A")}");
    }
}
