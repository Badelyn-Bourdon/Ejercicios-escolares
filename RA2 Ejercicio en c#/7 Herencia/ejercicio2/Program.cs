using System;

class BoletoTransporte
{
    public string Destino { get; set; }
    public string TipoTransporte { get; set; }
    public double CostoPorKilometro { get; set; }
    public double Distancia { get; set; }
    public double Tiempo { get; set; }
    public double PrecioBoleto { get; set; }

    public BoletoTransporte(string destino, string tipoTransporte, double costoPorKilometro, double distancia, double tiempo)
    {
        Destino = destino;
        TipoTransporte = tipoTransporte;
        CostoPorKilometro = costoPorKilometro;
        Distancia = distancia;
        Tiempo = tiempo;
        PrecioBoleto = CalcularPrecioBoleto();
    }

    public double CalcularPrecioBoleto()
    {
        return CostoPorKilometro * Distancia;
    }

    public void MostrarDetallesBoleto()
    {
        Console.WriteLine("Detalles del Boleto:");
        Console.WriteLine($"Destino: {Destino}");
        Console.WriteLine($"Tipo de Transporte: {TipoTransporte}");
        Console.WriteLine($"Distancia: {Distancia} km");
        Console.WriteLine($"Tiempo: {Tiempo} horas");
        Console.WriteLine($"Precio del Boleto: RD$ {PrecioBoleto}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el destino: ");
        string destino = Console.ReadLine();

        Console.Write("Ingrese el tipo de transporte (Ejemplo: Autobús, Taxi, Tren): ");
        string tipoTransporte = Console.ReadLine();

        Console.Write("Ingrese el costo por kilómetro: ");
        double costoPorKilometro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la distancia a recorrer (en km): ");
        double distancia = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo estimado (en horas): ");
        double tiempo = Convert.ToDouble(Console.ReadLine());

        BoletoTransporte boleto = new BoletoTransporte(destino, tipoTransporte, costoPorKilometro, distancia, tiempo);
        boleto.MostrarDetallesBoleto();
    }
}
