using System;

class Program
{
    static void Main()
    {
        // Variable para la suma
        int suma = 0;
        int cantidad = 100; // Cantidad de números naturales

        // Calcular la suma de los primeros 100 números naturales
        for (int i = 1; i <= cantidad; i++)
        {
            suma += i; // Sumar el número actual
        }

        // Calcular el promedio
        double promedio = (double)suma / cantidad;

        // Mostrar el resultado
        Console.WriteLine($"La suma de los primeros 100 números naturales es: {suma}");
        Console.WriteLine($"El promedio de los primeros 100 números naturales es: {promedio}");
    }
}
