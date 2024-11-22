using System;
using System.Collections.Generic;

// Clase Estudiante
class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Estudiante(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}

// Clase Asignatura
class Asignatura
{
    public string Nombre { get; set; }
    public double Calificacion { get; set; }

    public Asignatura(string nombre, double calificacion)
    {
        Nombre = nombre;
        Calificacion = calificacion;
    }
}

// Clase RegistroAcademico
class RegistroAcademico
{
    public Estudiante Estudiante { get; set; }
    private List<Asignatura> Asignaturas;

    public RegistroAcademico(Estudiante estudiante)
    {
        Estudiante = estudiante;
        Asignaturas = new List<Asignatura>();
    }

    public void AgregarAsignatura(string nombreAsignatura, double calificacion)
    {
        Asignaturas.Add(new Asignatura(nombreAsignatura, calificacion));
    }

    public double CalcularPromedio()
    {
        if (Asignaturas.Count == 0) return 0;

        double suma = 0;
        foreach (var asignatura in Asignaturas)
        {
            suma += asignatura.Calificacion;
        }

        return suma / Asignaturas.Count;
    }

    public void MostrarRegistro()
    {
        Console.WriteLine($"\nEstudiante: {Estudiante.Nombre}, Edad: {Estudiante.Edad}");
        Console.WriteLine("Detalles Académicos:");
        foreach (var asignatura in Asignaturas)
        {
            Console.WriteLine($"  - {asignatura.Nombre}: {asignatura.Calificacion}");
        }
        Console.WriteLine($"Promedio General: {CalcularPromedio():F2}\n");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<RegistroAcademico> registros = new List<RegistroAcademico>();

        while (true)
        {
            Console.WriteLine("\n===== Sistema de Gestión Académica =====");
            Console.WriteLine("Por favor, seleccione una opción del menú:");
            Console.WriteLine("1. Registrar un nuevo estudiante");
            Console.WriteLine("2. Añadir asignatura y calificación");
            Console.WriteLine("3. Consultar registros académicos");
            Console.WriteLine("4. Salir del sistema");
            Console.Write("Opción seleccionada: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("\nPor favor, ingrese el nombre completo del estudiante: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese la edad del estudiante: ");
                    if (!int.TryParse(Console.ReadLine(), out int edad) || edad <= 0)
                    {
                        Console.WriteLine("Edad no válida. Por favor intente nuevamente.");
                        break;
                    }

                    Estudiante estudiante = new Estudiante(nombre, edad);
                    registros.Add(new RegistroAcademico(estudiante));

                    Console.WriteLine("El estudiante ha sido registrado con éxito.\n");
                    break;

                case "2":
                    if (registros.Count == 0)
                    {
                        Console.WriteLine("Actualmente no hay estudiantes registrados. Por favor registre al menos un estudiante primero.\n");
                        break;
                    }

                    Console.WriteLine("\nSeleccione un estudiante ingresando el número correspondiente:");
                    for (int i = 0; i < registros.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {registros[i].Estudiante.Nombre}");
                    }

                    if (!int.TryParse(Console.ReadLine(), out int seleccion) || seleccion <= 0 || seleccion > registros.Count)
                    {
                        Console.WriteLine("Selección no válida. Por favor intente nuevamente.");
                        break;
                    }

                    var registroSeleccionado = registros[seleccion - 1];

                    Console.Write("Ingrese el nombre de la asignatura: ");
                    string nombreAsignatura = Console.ReadLine();
                    Console.Write("Ingrese la calificación obtenida: ");
                    if (!double.TryParse(Console.ReadLine(), out double calificacion) || calificacion < 0 || calificacion > 100)
                    {
                        Console.WriteLine("Calificación no válida. Por favor intente nuevamente.");
                        break;
                    }

                    registroSeleccionado.AgregarAsignatura(nombreAsignatura, calificacion);
                    Console.WriteLine("Asignatura y calificación añadidas con éxito.\n");
                    break;

                case "3":
                    if (registros.Count == 0)
                    {
                        Console.WriteLine("No hay registros académicos disponibles para mostrar.\n");
                        break;
                    }

                    Console.WriteLine("\n===== Registros Académicos =====");
                    foreach (var registro in registros)
                    {
                        registro.MostrarRegistro();
                    }
                    break;

                case "4":
                    Console.WriteLine("Gracias por utilizar el sistema de gestión académica. Hasta luego.");
                    return;

                default:
                    Console.WriteLine("Opción no reconocida. Por favor intente nuevamente.\n");
                    break;
            }
        }
    }
}


