using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[100]; // Se declara un arreglo con un tamaño máximo estimado (por ejemplo, 100 elementos)
        int suma = 0; // Variable para almacenar la suma de los números
        int contador = 0; // Contador para llevar el número de elementos en el arreglo

        Console.WriteLine("Ingrese números para sumar hasta que el total sea mayor o igual a 100:");

        // Bucle para leer números y sumar mientras la suma sea menor a 100
        while (suma < 100)
        {
            Console.Write($"Ingrese un número (número {contador + 1}): ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Guardar el número en el arreglo y aumentar el contador
            numeros[contador] = numero;
            contador++;

            // Sumar el número ingresado a la sumatoria total
            suma += numero;
        }

        // Mostrar el resultado en pantalla
        Console.WriteLine($"\nLa sumatoria de los números ingresados es: {suma}");
    }
}
