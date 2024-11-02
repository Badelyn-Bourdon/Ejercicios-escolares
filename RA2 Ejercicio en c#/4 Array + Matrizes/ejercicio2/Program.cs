using System;

class Program
{
    // Método que recibe dos arreglos: nombres de estudiantes y calificaciones
    static void MostrarEstudiantesYCalificaciones(string[] nombres, int[] calificaciones)
    {
        Console.WriteLine("\nLista de estudiantes y sus calificaciones:");
        for (int i = 0; i < nombres.Length; i++)
        {
            Console.WriteLine($"Estudiante: {nombres[i]}, Calificación: {calificaciones[i]}");
        }
    }

    static void Main()
    {
        // Solicitar la cantidad de estudiantes
        Console.Write("Ingrese la cantidad de estudiantes: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        // Definir los arreglos para nombres y calificaciones
        string[] nombres = new string[cantidad];
        int[] calificaciones = new int[cantidad];

        // Leer los datos de los estudiantes y sus calificaciones
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
            nombres[i] = Console.ReadLine();

            Console.Write($"Ingrese la calificación de {nombres[i]}: ");
            calificaciones[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Llamada al método para mostrar los nombres y calificaciones
        MostrarEstudiantesYCalificaciones(nombres, calificaciones);
    }
}
