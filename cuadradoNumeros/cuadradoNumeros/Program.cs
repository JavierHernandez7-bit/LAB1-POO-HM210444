using System;

namespace cuadradoNumeros
{
    class Program
    {
        static Double Potencia(Double x)
        {
            return x * x;
        }
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Potencia con funciones";
            Double x;
            for (x = 1; x <= 10; x++)
            {
                Console.WriteLine("\nEl cuadrado de " + x + " es: " + Potencia(x));
            }
            Console.ReadKey();
        }
    }
}
