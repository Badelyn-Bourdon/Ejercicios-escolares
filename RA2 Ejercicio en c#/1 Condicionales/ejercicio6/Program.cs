using System;

namespace EjercicioParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número entero
            Console.Write("Introduce un número entero: ");
            string input = Console.ReadLine();

            // Convertir la entrada a un número entero
            int numero;
            bool conversionExitosa = int.TryParse(input, out numero);

            // Verificar si la conversión fue exitosa
            if (conversionExitosa)
            {
                // Determinar si el número es par o impar
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par.");
                }
                else
                {
                    Console.WriteLine("El número es impar.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número entero válido.");
            }
        }
    }
}
