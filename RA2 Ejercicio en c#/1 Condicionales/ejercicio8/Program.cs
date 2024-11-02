using System;

namespace CompararTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número entero:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número entero:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el tercer número entero:");
            int numero3 = int.Parse(Console.ReadLine());

            // Comparar los tres números
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine($"El número mayor es: {numero1}");
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine($"El número mayor es: {numero2}");
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine($"El número mayor es: {numero3}");
            }
            else
            {
                Console.WriteLine("Hay al menos dos números iguales.");
            }
        }
    }
}


