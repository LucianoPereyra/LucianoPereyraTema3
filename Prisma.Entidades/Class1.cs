namespace ConsoleApp3
{
    public struct Prisma
    {
       
        public double Longitud { get; set; }
        public double Ancho { get; set; }
        public double Altura { get; set; }

        
        public void AsignarValores(double longitud, double ancho, double altura)
        {
            Longitud = longitud;
            Ancho = ancho;
            Altura = altura;
        }

        
        public double CalcularArea()
        {
            double areaBase = Longitud * Ancho;
            double perimetroBase = 2 * (Longitud + Ancho);
            double areaLateral = perimetroBase * Altura;
            return 2 * areaBase + areaLateral;
        }

       
        public double CalcularVolumen()
        {
            return Longitud * Ancho * Altura;
        }

        
        public double CalcularDiagonal()
        {
            return Math.Sqrt(Math.Pow(Longitud, 2) + Math.Pow(Ancho, 2) + Math.Pow(Altura, 2));
        }
    }
}
