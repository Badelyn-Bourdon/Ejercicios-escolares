using System;

class Program
{
    static void Main()
    {
        // Contraseña correcta
        string contraseñaCorrecta = "miContraseña123"; // Cambia esto por la contraseña deseada
        string contraseñaIngresada;
        int intentos = 3;

        // Bucle para los intentos
        for (int i = 0; i < intentos; i++)
        {
            Console.Write("Ingrese la contraseña: ");
            contraseñaIngresada = Console.ReadLine();

            // Verificar la contraseña
            if (contraseñaIngresada == contraseñaCorrecta)
            {
                Console.WriteLine("Contraseña correcta. Acceso concedido.");
                return; // Salir del programa si la contraseña es correcta
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
            }
        }

        // Si se agotaron los intentos
        Console.WriteLine("Ha agotado el número de intentos. El programa se terminará.");
    }
}
