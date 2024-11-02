
using System;

namespace EjercicioCompararNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el primer número
            Console.Write("Introduce el primer número entero: ");
            string input1 = Console.ReadLine();

            // Solicitar al usuario que ingrese el segundo número
            Console.Write("Introduce el segundo número entero: ");
            string input2 = Console.ReadLine();

            // Convertir las entradas a números enteros
            int numero1, numero2;
            bool conversion1Exitosa = int.TryParse(input1, out numero1);
            bool conversion2Exitosa = int.TryParse(input2, out numero2);

            // Verificar si ambas conversiones fueron exitosas
            if (conversion1Exitosa && conversion2Exitosa)
            {
                // Determinar cuál número es mayor o si son iguales
                if (numero1 > numero2)
                {
                    Console.WriteLine($"El primer número ({numero1}) es mayor que el segundo número ({numero2}).");
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine($"El segundo número ({numero2}) es mayor que el primer número ({numero1}).");
                }
                else
                {
                    Console.WriteLine("Ambos números son iguales.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce valores enteros válidos.");
            }
        }
    }
}
