using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[10]; // Declarar un arreglo para almacenar 10 enteros
        int suma = 0; // Variable para almacenar la suma

        Console.WriteLine("Introduce 10 números enteros:");

        // Bucle para leer los números ingresados por el usuario
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine()); // Leer número y almacenarlo en el arreglo
            suma += numeros[i]; // Sumar el número a la variable suma
        }

        // Mostrar el resultado de la suma
        Console.WriteLine($"La suma de los 10 números ingresados es: {suma}");
    }
}
