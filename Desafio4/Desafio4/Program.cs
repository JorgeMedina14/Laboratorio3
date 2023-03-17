namespace Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un miembro variable llamado SuperficieFrontal (resultado de multiplicar Alto por Largo), el cual debe ser de solo lectura.*/
            CalcularRect calcularrectangulo = new CalcularRect { Alto = 4.5, Largo = 10 };
            Console.WriteLine("La superficie frontal del rectangulo es:{0} ", calcularrectangulo.SuperfeciFrontal);
        }
    }
}