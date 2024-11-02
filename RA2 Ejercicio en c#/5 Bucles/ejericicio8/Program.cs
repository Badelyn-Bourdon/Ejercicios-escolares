using System;

class Program
{
    static void Main()
    {
        int numero;
        int sumatoria = 0; // Variable para almacenar la sumatoria

        Console.WriteLine("Introduce números para sumar. Ingresa 0 para finalizar.");

        do
        {
            // Leer un número ingresado por el usuario
            Console.Write("Ingresa un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            sumatoria += numero; // Sumar el número a la sumatoria
        } while (numero != 0); // Continuar hasta que el usuario ingrese 0

        // Mostrar el resultado de la sumatoria, excluyendo el 0
        Console.WriteLine($"La sumatoria de los números ingresados es: {sumatoria}");
    }
}

