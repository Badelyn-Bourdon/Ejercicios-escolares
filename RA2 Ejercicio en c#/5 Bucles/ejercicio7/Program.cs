using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario que ingrese un número
        Console.Write("Introduce un número para mostrar su tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Tabla de multiplicar del {numero}:");

        // Bucle para imprimir la tabla de multiplicar del 1 al 12
        for (int i = 1; i <= 12; i++)
        {
            int resultado = numero * i; // Calcular el resultado
            Console.WriteLine($"{numero} x {i} = {resultado}"); // Imprimir el resultado
        }
    }
}

