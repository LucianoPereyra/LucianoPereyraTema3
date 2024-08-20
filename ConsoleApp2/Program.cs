
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double maxVolumen = 0;
            double minVolumen = double.MaxValue; 
            double sumaVolumenes = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingresando datos del prisma {i + 1}:");

                double anchoPrisma = IngresarValorPositivo("Ingrese el ancho del prisma: ");
                double alturaPrisma = IngresarValorPositivo("Ingrese la altura del prisma: ");
                double longitudPrisma = IngresarValorPositivo("Ingrese la longitud del prisma: ");

                double volumen = longitudPrisma * anchoPrisma * alturaPrisma;
                sumaVolumenes += volumen;

                if (volumen > maxVolumen)
                {
                    maxVolumen = volumen; 
                }

                if (volumen < minVolumen)
                {
                    minVolumen = volumen; 
                }
            }

            double promedioVolumenes = sumaVolumenes / 5;

            Console.WriteLine($"El prisma con mayor volumen tiene un volumen de {maxVolumen}.");
            Console.WriteLine($"El prisma con menor volumen tiene un volumen de {minVolumen}.");
            Console.WriteLine($"El promedio de volumenes de los prismas es {promedioVolumenes}");
        }

        static double IngresarValorPositivo(string mensaje)
        {
            double valor;
            do
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    return valor;
                }
                else
                {
                    Console.WriteLine("El valor debe ser un número positivo.");
                }
            } while (true);

        }
    }
}
