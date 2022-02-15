using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            long factorial = 1;
            for (int i = numero; i > 1; i--)
                factorial *= i;
            Console.WriteLine("El factorial de " + numero + " es " + factorial);
            Console.ReadLine();
        }
    }
}
