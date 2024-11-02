using System;

namespace OrdenarTresNumeros
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

            int mayor, central, menor;

            // Comparar para encontrar el mayor, el central y el menor
            if (numero1 >= numero2 && numero1 >= numero3)
            {
                mayor = numero1;
                if (numero2 >= numero3)
                {
                    central = numero2;
                    menor = numero3;
                }
                else
                {
                    central = numero3;
                    menor = numero2;
                }
            }
            else if (numero2 >= numero1 && numero2 >= numero3)
            {
                mayor = numero2;
                if (numero1 >= numero3)
                {
                    central = numero1;
                    menor = numero3;
                }
                else
                {
                    central = numero3;
                    menor = numero1;
                }
            }
            else
            {
                mayor = numero3;
                if (numero1 >= numero2)
                {
                    central = numero1;
                    menor = numero2;
                }
                else
                {
                    central = numero2;
                    menor = numero1;
                }
            }

            // Mostrar resultados
            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número central es: {central}");
            Console.WriteLine($"El número menor es: {menor}");
        }
    }
}
