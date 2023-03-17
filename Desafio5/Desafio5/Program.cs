namespace Desafio5
{ class Caja
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public double CalcularVolumen()
        {
            return Largo + Ancho + Alto;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Caja[] cajas = new Caja[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese los valores de la caja " + (i + 1) + ":");
                cajas[i] = new Caja
                {
                    Largo = double.Parse(Console.ReadLine()),
                    Ancho = double.Parse(Console.ReadLine()),
                    Alto = double.Parse(Console.ReadLine())
                };
            }
            double totalVolumen = 0;
            for (int i = 0; i < n; i++)
            {
                totalVolumen += cajas[i].CalcularVolumen();
            }
            double volumenPromedio = totalVolumen / n;
            Console.WriteLine("El total de volumen de las cajas es: " + totalVolumen);
            Console.WriteLine("El volumen promedio de las cajas es: " + volumenPromedio);

        }
    }
}