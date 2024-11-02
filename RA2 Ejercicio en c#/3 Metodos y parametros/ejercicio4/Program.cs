using System;

class Program
{
    // Método para calcular el promedio
    static double CalcularPromedio(double nota1, double nota2, double nota3, double nota4)
    {
        return (nota1 + nota2 + nota3 + nota4) / 4;
    }

    // Método para calcular la nota completiva
    static double CalcularNotaCompletivo(double promedio, double examenCompletivo)
    {
        double notaPromedioCompletivo = promedio * 0.5 + examenCompletivo * 0.5;
        return notaPromedioCompletivo;
    }

    // Método para calcular la nota extraordinaria
    static double CalcularNotaExtraordinario(double promedio, double examenExtraordinario)
    {
        double notaPromedioExtraordinario = promedio * 0.3 + examenExtraordinario * 0.7;
        return notaPromedioExtraordinario;
    }

    static void Main()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese la materia: ");
        string materia = Console.ReadLine();

        // Leer las 4 notas
        Console.WriteLine("Ingrese las 4 notas del estudiante:");
        double nota1 = Convert.ToDouble(Console.ReadLine());
        double nota2 = Convert.ToDouble(Console.ReadLine());
        double nota3 = Convert.ToDouble(Console.ReadLine());
        double nota4 = Convert.ToDouble(Console.ReadLine());

        // Calcular el promedio
        double promedio = CalcularPromedio(nota1, nota2, nota3, nota4);

        // Verificar si aprobó o reprobó
        if (promedio >= 70)
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Materia: {materia}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("El estudiante aprobó.");
        }
        else
        {
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Materia: {materia}");
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("El estudiante reprobó, debe ir a completivo.");

            // Leer nota del examen completivo
            Console.Write("Ingrese la nota del examen completivo: ");
            double examenCompletivo = Convert.ToDouble(Console.ReadLine());
            double notaCompletivo = CalcularNotaCompletivo(promedio, examenCompletivo);

            if (notaCompletivo >= 70)
            {
                Console.WriteLine($"Nota completiva: {notaCompletivo}");
                Console.WriteLine("El estudiante aprobó el completivo.");
            }
            else
            {
                Console.WriteLine($"Nota completiva: {notaCompletivo}");
                Console.WriteLine("El estudiante reprobó el completivo, debe ir a extraordinario.");

                // Leer nota del examen extraordinario
                Console.Write("Ingrese la nota del examen extraordinario: ");
                double examenExtraordinario = Convert.ToDouble(Console.ReadLine());
                double notaExtraordinario = CalcularNotaExtraordinario(promedio, examenExtraordinario);

                if (notaExtraordinario >= 70)
                {
                    Console.WriteLine($"Nota extraordinaria: {notaExtraordinario}");
                    Console.WriteLine("El estudiante aprobó el extraordinario.");
                }
                else
                {
                    Console.WriteLine($"Nota extraordinaria: {notaExtraordinario}");
                    Console.WriteLine("El estudiante reprobó.");
                }
            }
        }
    }
}
