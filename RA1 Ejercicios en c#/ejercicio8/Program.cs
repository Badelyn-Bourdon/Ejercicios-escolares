using System;

class CalculoAumentoSueldo
{
    static void Main()
    {
        // Solicitar el sueldo actual del empleado
        Console.WriteLine("Introduce el sueldo actual del empleado:");
        decimal sueldoAnterior = decimal.Parse(Console.ReadLine());

        // Calcular el aumento (15%)
        decimal aumento = sueldoAnterior * 0.15m;

        // Calcular el nuevo sueldo
        decimal nuevoSueldo = sueldoAnterior + aumento;

        // Mostrar el sueldo anterior y el nuevo sueldo
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Sueldo Anterior: " + sueldoAnterior.ToString("C"));
        Console.WriteLine("Aumento (15%): " + aumento.ToString("C"));
        Console.WriteLine("Nuevo Sueldo: " + nuevoSueldo.ToString("C"));
    }
}
