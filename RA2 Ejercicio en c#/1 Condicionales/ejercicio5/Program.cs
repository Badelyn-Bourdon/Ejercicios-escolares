namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //entrada de datos 

            Console.WriteLine("Indroduzca el numero por favor: ");  
            string input = Console.ReadLine();

            //convirtiendo mi numero a entero
            int numero;
            bool convercionAprobada = int.TryParse(input, out numero);
            
            //processo

            if (convercionAprobada)
            {
                
                if ( numero > 0) 
                {
                    Console.WriteLine("el numero es positivo. ");

                }
                else if (numero < 0)
                {
                    Console.WriteLine("el numero es negativo. ");
                }
                else
                {
                    Console.WriteLine("el numero es cero");
                }

            }
            else
            {
                Console.WriteLine("Ingrese un valor valido");
            }


        }
    }
}
