using System;

class Program
{
    static void Main()
    {
        // Variable para la suma
        int suma = 0;

        // Calcular la suma de los primeros 100 números naturales
        for (int i = 1; i <= 100; i++)
        {
            suma += i; // Sumar el número actual
        }

        // Mostrar el resultado
        Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");
    }
}
