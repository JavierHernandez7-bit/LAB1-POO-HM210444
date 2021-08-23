using System;

namespace conversionGrados
{
    class Program
    {
        static void Faren()
        {
            Double cel, far;
            Console.WriteLine("Escribe los grados Celsius: ");
            cel = Convert.ToDouble(Console.ReadLine());
            far = cel * 9.0 / 5.0 + 32;
            Console.WriteLine("{0}° Celsius son {1} grados Fahrenheit", cel, far);
        }
        static void Celsi()
        {
            Double cel, far;
            Console.WriteLine("Escribe los grados Fahrenheit: ");
            far = Convert.ToDouble(Console.ReadLine());
            cel = (far - 32) * 5.0 / 9.0;
            Console.WriteLine("{0} grados Fahrenheit son {1} grados Celsius", far, cel);
        }
        static void Kelvin()
        {

        }
        static void Main(string[] args)
        {
            string opc;
            Console.WriteLine("\t \t Programa para convertir temperaturas");
            Console.WriteLine("\nElige el tipo de conversión");
            Console.WriteLine("\n \nPresiona F si quiere convertir Celsius a Fahrenheit");
            Console.WriteLine("Presiona C si quiere convertir Fahrenheit a Celsius");
            Console.WriteLine("\nElige F o C: ");
            opc = Console.ReadLine();
            switch (opc)
            {
                case "F":
                case "f":
                    Console.WriteLine("\nConversión F");
                    Faren();
                    break;
                case "C":
                case "c":
                    Console.WriteLine("\nConversión C");
                    Celsi();
                    break;
                default:
                    Console.WriteLine("\nTipo de conversión no válida");
                    break;
            }
        }
    }
}
