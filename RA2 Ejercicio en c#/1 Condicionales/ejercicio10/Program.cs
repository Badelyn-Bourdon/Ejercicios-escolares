using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese el salario anual del empleado:");
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        decimal isr = CalcularISR(salario);

        if (isr > 0)
        {
            Console.WriteLine($"El ISR a pagar es: {isr:C}");
        }
        else
        {
            Console.WriteLine("No Aplica para ISR.");
        }
    }

    static decimal CalcularISR(decimal salario)
    {
        // Definir límites y montos de cada tramo
        decimal exento = 416220.00m;           // Monto exento
        decimal limite1 = 624329.00m;          // Límite del segundo tramo
        decimal limite2 = 867123.00m;          // Límite del tercer tramo

        decimal tasa1 = 0.15m;                 // Tasa para el segundo tramo
        decimal tasa2 = 0.20m;                 // Tasa para el tercer tramo
        decimal tasa3 = 0.25m;                 // Tasa para el cuarto tramo

        decimal montoTramo3 = 31216.00m;       // Monto fijo para el tercer tramo
        decimal montoTramo4 = 79776.00m;       // Monto fijo para el cuarto tramo

        decimal isr = 0;

        if (salario <= exento)
        {
            // Si el salario es menor o igual al monto exento
            isr = 0;
        }
        else if (salario <= limite1)
        {
            // Salario en el segundo tramo
            isr = (salario - exento) * tasa1;
        }
        else if (salario <= limite2)
        {
            // Salario en el tercer tramo
            isr = montoTramo3 + (salario - limite1) * tasa2;
        }
        else
        {
            // Salario en el cuarto tramo
            isr = montoTramo4 + (salario - limite2) * tasa3;
        }

        return isr;
    }
}
