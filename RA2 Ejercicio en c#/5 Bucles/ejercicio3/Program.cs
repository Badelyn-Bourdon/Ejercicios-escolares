using System;

class Program
{
    static void Main()
    {
        // Variable para la sumatoria
        int sumatoria = 0;

        // Leer la cantidad de números a ingresar
        Console.Write("Ingrese la cantidad de números que desea introducir: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Bucle para leer los números
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            sumatoria += numero; // Sumar el número ingresado a la sumatoria
        }

        // Verificar si la sumatoria es mayor o igual a 100
        if (sumatoria >= 100)
        {
            Console.WriteLine("La sumatoria es mayor o igual a 100.");
        }
        else
        {
            Console.WriteLine("La sumatoria es menor a 100.");
        }
    }
}
