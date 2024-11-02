using System;

class OperacionesAritmeticasConTresNumeros
{
    static void Main()
    {
        // Solicitar los tres números al usuario
        Console.WriteLine("Introduce el primer número entero:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el segundo número entero:");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduce el tercer número entero:");
        int numero3 = int.Parse(Console.ReadLine());

        // Realizar las operaciones
        int suma = numero1 + numero2 + numero3;
        int resta = numero1 - numero2 - numero3;
        int multiplicacion = numero1 * numero2 * numero3;
        float division = (float)numero1 / numero2 / numero3;

        // Mostrar los resultados
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Resta: " + resta);
        Console.WriteLine("Multiplicación: " + multiplicacion);

        // Evitar división por cero
        if (numero2 != 0 && numero3 != 0)
        {
            Console.WriteLine("División: " + division);
        }
        else
        {
            Console.WriteLine("No se puede dividir entre 0.");
        }
    }
}
