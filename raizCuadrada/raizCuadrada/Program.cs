using System;

namespace raizCuadrada
{
    class Program
    {
        static void Raiz()
        {
            Console.WriteLine("Calculo de raices");
            for (int i = 1; i < 10;i++) 
            {
                Console.WriteLine("\nLa raiz cuadrada del numero " + i + " es:" + Math.Sqrt(i));

            }
        }
        static void Main(string[] args)
        {
            Raiz();
            Console.ReadKey();
        }
    }
}
