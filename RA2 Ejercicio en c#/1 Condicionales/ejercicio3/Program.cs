namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {



           
            //Entrada de datos 

            Console.Write("Ingresar la primera nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine()); 

            Console.Write("Ingresar la segunda nota: ");      
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresar la tercera nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresar la cuarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            //calcular el promedio
           double  promedio = (nota1 + nota2 + nota3 + nota4) /4;

            if ( promedio >=70)
            {
                Console.WriteLine("Aprobaste a chepa na, mentira orgullosa de ti bb;)" + promedio);
            }
            else
            {
                Console.WriteLine("No aprobaste amigo que paso ?: " + promedio);
            }




           
        }
    }
}
