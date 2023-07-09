using System;

namespace Tarea06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la primera nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            double promedio = (nota1 * 2 + nota2 * 3) / 5;

            Console.WriteLine("El promedio ponderado de las notas es: " + promedio.ToString());

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
    }
}

