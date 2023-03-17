namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que solicite al usuario que ingrese un número entero positivo y muestre todos los números pares desde
            //1 hasta el número ingresado. Si el número actual no es par, el programa debe continuar con el siguiente número sin imprimir nada.
            Console.WriteLine("Ingrese un numero");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}