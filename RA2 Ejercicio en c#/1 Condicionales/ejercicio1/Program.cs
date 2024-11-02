using System;

class EntradaDiscoteca
{
    static void Main()
    {
        // Solicitar la edad
        Console.WriteLine("Introduce la edad:");
        int edad = int.Parse(Console.ReadLine());

        // Solicitar el sexo (H para hembra, V para varón)
        Console.WriteLine("Introduce el sexo (H para hembra, V para varón):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        // Verificar si la persona es mayor de edad
        if (edad >= 18)
        {
            // Determinar si puede entrar gratis o pagando según el sexo
            if (sexo == 'H')
            {
                Console.WriteLine("Puedes entrar gratis.");
            }
            else if (sexo == 'V')
            {
                Console.WriteLine("Puedes entrar, pero debes pagar.");
            }
            else
            {
                Console.WriteLine("Sexo no válido. Introduce H para hembra o V para varón.");
            }
        }
        else
        {
            Console.WriteLine("No puedes entrar, eres menor de edad.");
        }
    }
}
