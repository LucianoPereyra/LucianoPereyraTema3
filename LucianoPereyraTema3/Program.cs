namespace LucianoPereyraTema3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la longitud del prisma rectangular: ");
            var longitudPrisma = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el ancho del prisma rectangular: ");
            var anchoPrisma = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la altura del prisma rectangular: ");
            var alturaPrisma = double.Parse(Console.ReadLine());

            
            var volumenPrisma = longitudPrisma * anchoPrisma * alturaPrisma;
            Console.WriteLine($"El volumen del prisma es {volumenPrisma}");

            var areaPrisma = 2 * (longitudPrisma * alturaPrisma + longitudPrisma * alturaPrisma
                + alturaPrisma * anchoPrisma);

            Console.WriteLine($"El área del prisma es {areaPrisma}");

            var diagonalPrisma = Math.Sqrt(longitudPrisma*2+anchoPrisma*2 + 
                alturaPrisma*2);

            Console.WriteLine($"La diagonal del prisma es {diagonalPrisma}");
        }
    }
}
