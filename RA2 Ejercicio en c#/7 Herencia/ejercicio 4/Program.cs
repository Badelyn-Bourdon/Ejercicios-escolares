using System;

class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    public virtual void MostrarDetalles()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Precio: RD$ {Precio}");
        Console.WriteLine($"Cantidad: {Cantidad}");
    }
}

class ProductoElectronico : Producto
{
    public string Marca { get; set; }
    public int Garantia { get; set; } // En meses

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Garantía: {Garantia} meses");
    }
}

class ProductoAlimenticio : Producto
{
    public DateTime FechaExpiracion { get; set; }

    public override void MostrarDetalles()
    {
        base.MostrarDetalles();
        Console.WriteLine($"Fecha de Expiración: {FechaExpiracion.ToShortDateString()}");
    }
}

class Program
{
    static void Main()
    {
        // Capturando datos del producto electrónico
        ProductoElectronico productoElect = new ProductoElectronico();
        Console.WriteLine("Ingrese los datos del producto electrónico:");
        Console.Write("Nombre: ");
        productoElect.Nombre = Console.ReadLine();
        Console.Write("Precio: ");
        productoElect.Precio = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Cantidad: ");
        productoElect.Cantidad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Marca: ");
        productoElect.Marca = Console.ReadLine();
        Console.Write("Garantía (meses): ");
        productoElect.Garantia = Convert.ToInt32(Console.ReadLine());

        // Capturando datos del producto alimenticio
        ProductoAlimenticio productoAlim = new ProductoAlimenticio();
        Console.WriteLine("\nIngrese los datos del producto alimenticio:");
        Console.Write("Nombre: ");
        productoAlim.Nombre = Console.ReadLine();
        Console.Write("Precio: ");
        productoAlim.Precio = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Cantidad: ");
        productoAlim.Cantidad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Fecha de Expiración (dd/mm/yyyy): ");
        productoAlim.FechaExpiracion = DateTime.Parse(Console.ReadLine());

        // Mostrando detalles
        Console.WriteLine("\nDetalles del Producto Electrónico:");
        productoElect.MostrarDetalles();

        Console.WriteLine("\nDetalles del Producto Alimenticio:");
        productoAlim.MostrarDetalles();
    }
}
