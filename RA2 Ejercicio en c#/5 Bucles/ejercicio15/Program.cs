using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario la cantidad de caracteres a ingresar
        Console.Write("¿Cuántos caracteres deseas ingresar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine()); // Leer la cantidad de caracteres

        char[] caracteres = new char[cantidad]; // Declarar un arreglo para almacenar los caracteres

        Console.WriteLine($"Introduce {cantidad} caracteres:");

        // Bucle para leer los caracteres ingresados por el usuario
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Caracter {i + 1}: ");
            caracteres[i] = Convert.ToChar(Console.ReadLine()); // Leer carácter y almacenarlo en el arreglo
        }

        // Mostrar la lista de elementos original
        Console.WriteLine("Elementos originales:");
        foreach (char c in caracteres)
        {
            Console.Write(c + " "); // Imprimir cada carácter
        }
        Console.WriteLine();

        // Ordenar el arreglo de caracteres
        Array.Sort(caracteres);

        // Mostrar la lista de elementos ordenados
        Console.WriteLine("Elementos ordenados:");
        foreach (char c in caracteres)
        {
            Console.Write(c + " "); // Imprimir cada carácter
        }
        Console.WriteLine();
    }
}
