namespace Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que solicite al usuario que ingrese un número entero positivo y determine si es un número primo o no utilizando un loop "for".
            //Si el número es primo, el programa debe imprimir un mensaje indicando que es primo y salir del loop utilizando "break" 
            Console.WriteLine("Ingresa un numero");
            int n = int.Parse(Console.ReadLine());


            bool primo = true;
            for (int i = 2; i < n; i = i++)
            {
                if (i % 2 == 0)
                {
                    primo = false;
                    break;
                }
            }
            if (primo)
            {
                Console.WriteLine("{0} el numero ingresado es un numero primo",n);
            }
            else
            {
                Console.WriteLine("{0} el numero ingresado no es numero primo", n);
            }  
            
        }
    }
}