using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario cuántos números desea ingresar
        Console.Write("¿Cuántos números enteros deseas ingresar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine()); // Leer la cantidad de elementos

        int[] numeros = new int[cantidad]; // Declarar un arreglo para almacenar los números
        int contadorPares = 0; // Variable para contar los números pares

        Console.WriteLine($"Introduce {cantidad} números enteros:");

        // Bucle para leer los números ingresados por el usuario
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine()); // Leer número y almacenarlo en el arreglo

            // Verificar si el número es par
            if (numeros[i] % 2 == 0)
            {
                contadorPares++; // Incrementar el contador si es par
            }
        }

        // Mostrar el resultado del conteo de números pares
        Console.WriteLine($"La cantidad de números pares ingresados es: {contadorPares}");
    }
}
