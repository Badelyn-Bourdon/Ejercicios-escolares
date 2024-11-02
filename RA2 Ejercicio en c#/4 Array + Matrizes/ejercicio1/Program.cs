using System;

class Program
{
    static void Main()
    {
        // Ejemplo de matriz de inventario
        // Cada fila representa un tipo de dispositivo, y cada columna representa un almacén
        int[,] inventario = {
            { 50, 20, 30 }, // Televisores en cada almacén
            { 40, 25, 10 }, // Laptops en cada almacén
            { 60, 30, 15 }, // Teléfonos en cada almacén
            { 20, 15, 40 }  // Tablets en cada almacén
        };

        string[] dispositivos = { "Televisores", "Laptops", "Teléfonos", "Tablets" };
        int numDispositivos = inventario.GetLength(0); // Número de filas (dispositivos)
        int numAlmacenes = inventario.GetLength(1);    // Número de columnas (almacenes)

        // 1. Calcular la cantidad total de dispositivos en cada almacén
        Console.WriteLine("Cantidad total de dispositivos en cada almacén:");
        for (int col = 0; col < numAlmacenes; col++)
        {
            int totalAlmacen = 0;
            for (int fila = 0; fila < numDispositivos; fila++)
            {
                totalAlmacen += inventario[fila, col];
            }
            Console.WriteLine($"Almacén {col + 1}: {totalAlmacen} dispositivos");
        }

        // 2. Determinar el dispositivo con mayor y menor cantidad en cada almacén
        Console.WriteLine("\nDispositivos con mayor y menor cantidad en cada almacén:");
        for (int col = 0; col < numAlmacenes; col++)
        {
            int maxCantidad = inventario[0, col];
            int minCantidad = inventario[0, col];
            string dispositivoMax = dispositivos[0];
            string dispositivoMin = dispositivos[0];

            for (int fila = 1; fila < numDispositivos; fila++)
            {
                if (inventario[fila, col] > maxCantidad)
                {
                    maxCantidad = inventario[fila, col];
                    dispositivoMax = dispositivos[fila];
                }
                if (inventario[fila, col] < minCantidad)
                {
                    minCantidad = inventario[fila, col];
                    dispositivoMin = dispositivos[fila];
                }
            }
            Console.WriteLine($"Almacén {col + 1}: Mayor - {dispositivoMax} ({maxCantidad}), Menor - {dispositivoMin} ({minCantidad})");
        }
    }
}
