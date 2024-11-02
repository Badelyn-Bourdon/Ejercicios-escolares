using System.ComponentModel.Design;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            Console.Write("Ingrese la primera nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingresar la segundo nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresar la tercera nota: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresar la cuarta nota: ");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            //calculando mi promedio 
            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;


            //determinando la situacion de mi estudiante 
            string situacion;

            if (promedio >= 90 && promedio <= 100)
            {
                situacion = "Exelente";
            }

            else if (promedio >= 80 && promedio <= 89)
            {
                situacion = "Muy bueno";
            }

            else if (promedio >= 75 && promedio <= 79)
            {
                situacion = "Bueno";
            }

            else if (promedio >= 70 && promedio <= 74)
            {
                situacion = "regular";

            }

            else  
            {
                situacion = "deficiente";
            }


            //mostrando el promedio del estudiante 
            Console.WriteLine("el promedio del estudiante es: " + promedio);

            //mostrando la situacion de mi estudiante 
            Console.WriteLine("Situacion del estudiante: " + situacion);

            //condicion para saber si el estudiante paso 
            if (promedio >=70)
            {
                Console.WriteLine("Felicidades pasaste");

;           }
            else if (promedio <= 89) 
            {
                Console.WriteLine("lo sentimos no pasaste");
            }
                    
        }
    }
}
