using System;

class Program
{
    static void Main()
    {
        // Variables para contar
        int contadorPositivos = 0;
        int contadorNegativos = 0;
        int contadorPares = 0;
        int contadorImpares = 0;

        // Leer la cantidad de números a ingresar
        Console.Write("Ingrese la cantidad de números que desea introducir: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Bucle para leer los números
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Contar números positivos y negativos
            if (numero > 0)
            {
                contadorPositivos++;
            }
            else if (numero < 0)
            {
                contadorNegativos++;
            }

            // Contar números pares e impares
            if (numero % 2 == 0)
            {
                contadorPares++;
            }
            else
            {
                contadorImpares++;
            }
        }

        // Mostrar resultados
        Console.WriteLine($"Cantidad de números positivos: {contadorPositivos}");
        Console.WriteLine($"Cantidad de números negativos: {contadorNegativos}");
        Console.WriteLine($"Cantidad de números pares: {contadorPares}");
        Console.WriteLine($"Cantidad de números impares: {contadorImpares}");
    }
}
