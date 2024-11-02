using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario cuántos elementos quiere ingresar
        Console.Write("¿Cuántos números decimales deseas multiplicar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine()); // Leer la cantidad de elementos

        decimal[] numeros = new decimal[cantidad]; // Declarar un arreglo para almacenar los números
        decimal producto = 1; // Variable para almacenar el producto, inicializada en 1

        Console.WriteLine($"Introduce {cantidad} números decimales:");

        // Bucle para leer los números ingresados por el usuario
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = Convert.ToDecimal(Console.ReadLine()); // Leer número y almacenarlo en el arreglo
            producto *= numeros[i]; // Multiplicar el número al producto
        }

        // Mostrar el resultado del producto
        Console.WriteLine($"El producto de los números ingresados es: {producto}");
    }
}
