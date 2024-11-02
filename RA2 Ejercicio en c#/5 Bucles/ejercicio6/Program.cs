using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Los números impares del 1 al 30 son:");

        // Bucle para imprimir números impares del 1 al 30
        for (int i = 1; i <= 30; i++)
        {
            if (i % 2 != 0) // Verificar si el número es impar
            {
                Console.WriteLine(i); // Imprimir el número impar
            }
        }
    }
}

