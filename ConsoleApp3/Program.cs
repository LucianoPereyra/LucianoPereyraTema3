using System;


namespace ConsoleApp3
{
    public class Class1
    {

        class Program
        {
            static void Main(string[] args)
            {
                
                Prisma prisma = new Prisma();

                
                Console.Write("Ingrese la longitud del prisma: ");
                double longitud = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el ancho del prisma: ");
                double ancho = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese la altura del prisma: ");
                double altura = Convert.ToDouble(Console.ReadLine());

           
                prisma.AsignarValores(longitud, ancho, altura);

                
                Console.WriteLine($"Área del prisma: {prisma.CalcularArea()}");
                Console.WriteLine($"Volumen del prisma: {prisma.CalcularVolumen()}");
                Console.WriteLine($"Diagonal del prisma: {prisma.CalcularDiagonal()}");
            }
        }
    }
}