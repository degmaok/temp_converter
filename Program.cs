using System;

class Program
{
    static void Main()
    {
        bool seguir = true;

        while (seguir)
        {
            Console.WriteLine("\nConversor de temperatura");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Fahrenheit a Celsius");
            Console.WriteLine("3. Celsius a Kelvin");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.WriteLine("0. Salir");
            Console.Write("Elegí una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                seguir = false;
                Console.WriteLine("¡Hasta luego!");
                continue;
            }

            if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4")
            {
                Console.WriteLine("Opción inválida.");
                continue;
            }

            Console.Write("Ingresá el valor: ");
            if (!double.TryParse(Console.ReadLine(), out double valor))
            {
                Console.WriteLine("Valor inválido.");
                continue;
            }

            switch (opcion)
            {
                case "1": Console.WriteLine($"{valor} °C = {valor * 9 / 5 + 32} °F"); break;
                case "2": Console.WriteLine($"{valor} °F = {(valor - 32) * 5 / 9} °C"); break;
                case "3": Console.WriteLine($"{valor} °C = {valor + 273.15} K"); break;
                case "4": Console.WriteLine($"{valor} K = {valor - 273.15} °C"); break;
            }
        }
    }
}