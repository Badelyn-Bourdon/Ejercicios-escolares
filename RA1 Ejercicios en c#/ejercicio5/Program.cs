using System;

class CalculoPromedio
{
    static void Main()
    {
        // Declarar un arreglo para almacenar los números
        int[] numeros = new int[5];
        int suma = 0;

        // Leer los 5 números del usuario
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Introduce el número " + (i + 1) + ":");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i]; // Sumar cada número a la variable 'suma'
        }

        // Calcular el promedio
        float promedio = (float)suma / 5;

        // Mostrar el resultado
        Console.WriteLine("\nEl promedio de los 5 números es: " + promedio);
    }
}
