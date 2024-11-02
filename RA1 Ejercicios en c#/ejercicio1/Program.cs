using System;

class OperacionesAritmeticas
{
    static void Main()
    {
        // Solicitar los dos números al usuario
        Console.WriteLine("Introduce el primer número entero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        // Realizar las operaciones
        int suma = numero1 + numero2;
        int resta = numero1 - numero2;
        int multiplicacion = numero1 * numero2;
        float division = (float)numero1 / numero2;

        // Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);
        if (numero2 != 0)
        {
            Console.WriteLine("División: " + division);
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }
    }
}
