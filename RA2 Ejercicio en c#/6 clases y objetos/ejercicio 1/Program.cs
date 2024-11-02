using System;

public class Articulos
{
    // Propiedades
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public string Categoria { get; set; }

    // Constructor
    public Articulos(string nombre, decimal precio, string categoria)
    {
        Nombre = nombre;
        Precio = precio;
        Categoria = categoria;
    }

    // Método para mostrar los detalles del artículo
    public void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: ${Precio}");
        Console.WriteLine($"Categoría: {Categoria}");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Ingrese el nombre del artículo:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del artículo:");
        decimal precio = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Ingrese la categoría del artículo:");
        string categoria = Console.ReadLine();

        // Crear instancia de la clase Articulos
        Articulos articulo = new Articulos(nombre, precio, categoria);

        // Mostrar los detalles del artículo
        Console.WriteLine("\nDetalles del artículo:");
        articulo.MostrarDetalles();
    }
}
