using System;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escribe una cadena: ");
            string cadena = Console.ReadLine();
            string reversa = "";
            foreach (char character in cadena)
                reversa = character + reversa;
            if (reversa == cadena)
            {
                Console.WriteLine("La cadena " + cadena + " es capicúa.");
            } else
            {
                Console.WriteLine("La cadena " + cadena + " no es capicúa.");
            }
            Console.ReadLine();
        }
    }
}
