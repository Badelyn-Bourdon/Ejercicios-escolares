using System;

// Clase base
class Operacion
{
    public double numero1;
    public double numero2;

    public Operacion(double n1, double n2)
    {
        numero1 = n1;
        numero2 = n2;
    }

    public virtual double Calcular()
    {
        return 0; // Método virtual que puede ser sobreescrito
    }
}

// Clase derivada para la suma
class Suma : Operacion
{
    public Suma(double n1, double n2) : base(n1, n2) { }

    public override double Calcular()
    {
        return numero1 + numero2;
    }
}

// Clase principal
class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Suma suma = new Suma(num1, num2);

        Console.WriteLine($"La suma es: {suma.Calcular()}");
    }
}
