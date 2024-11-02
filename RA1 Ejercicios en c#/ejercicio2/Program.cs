using System;

class CalculoSueldoNeto
{
    static void Main()
    {
        // Solicitar el pago por hora y las horas trabajadas
        Console.WriteLine("Introduce el pago por hora del empleado:");
        decimal pagoPorHora = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Introduce las horas trabajadas por el empleado:");
        decimal horasTrabajadas = decimal.Parse(Console.ReadLine());

        // Calcular el sueldo bruto
        decimal sueldoBruto = pagoPorHora * horasTrabajadas;

        // Calcular los descuentos
        decimal descuentoAFP = sueldoBruto * 0.0287m;
        decimal descuentoSFS = sueldoBruto * 0.0304m;
        decimal totalDescuentos = descuentoAFP + descuentoSFS;

        // Calcular el sueldo neto
        decimal sueldoNeto = sueldoBruto - totalDescuentos;

        // Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Sueldo Bruto: " + sueldoBruto.ToString("C"));
        Console.WriteLine("Descuento AFP (2.87%): " + descuentoAFP.ToString("C"));
        Console.WriteLine("Descuento SFS (3.04%): " + descuentoSFS.ToString("C"));
        Console.WriteLine("Total Descuentos: " + totalDescuentos.ToString("C"));
        Console.WriteLine("Sueldo Neto: " + sueldoNeto.ToString("C"));
    }
}
