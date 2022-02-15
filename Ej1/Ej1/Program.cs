using System;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce la cantidad que quieres comprar.");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero < 200)
            {
                Console.WriteLine("El precio es de " + numero * 4.50f + " eur.");
                Console.WriteLine("4.50 eur la unidad.");
            }
            else if (numero >= 200 && numero <= 500)
            {
                Console.WriteLine("El precio es de " + numero * 3.75f + " eur.");
                Console.WriteLine("3.75 eur la unidad.");
            }
            else
            {
                Console.WriteLine("El precio es de " + numero * 3.25f + " eur.");
                Console.WriteLine("3.25 eur la unidad.");
            }
            string salir = Console.ReadLine();
        }
    }
}
