namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Imagina que eres un desarrollador y obtienes un trabajo en el que necesitas crear un programa para un maestro. Él necesita un programa escrito en C# que calcule el
             puntaje promedio de un estudiante. Por lo tanto, quiere poder ingresar cada puntaje de ese alumno individualmente. 
            Cuando termine de cargar todas las calificaciones del alumno, debe escribir la palabra "fin" para que el programa le devuelva el promedio que ese alumno ha logrado.

            Por lo tanto, la herramienta debe verificar si la entrada es un número y agregarlo a la suma. Finalmente, una vez que haya terminado de ingresar puntajes,
            el programa debe escribir en la consola cuál es el puntaje promedio.
            Los números ingresados solo pueden estar entre 1 y 10. Asegúrate de que el programa no se bloquee si el maestro ingresa un valor incorrecto. 
            Testea tu programa para asegurarte de que no tenga errores.*/

            Console.WriteLine("Ingrese los puntajes del alumno (1 a 10), ingresar \"fin\"para terminar: ");
            int t = 0;
            int conta = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "fin")
                {
                    break;
                }
                if(int.TryParse(input, out int nota) && nota >=1 && nota <= 10)
                {
                    t += nota;
                    conta++;
                }
                else
                {
                    Console.WriteLine("El valor ingresado no es valido, porfavor ingrese un numero entero positivo o ingrese \"fin\"para terminar");
                }
            }
            double promedio = (double)t / conta;
            Console.WriteLine("El promedio del alumno es: {0}",promedio);
        }
    }
}