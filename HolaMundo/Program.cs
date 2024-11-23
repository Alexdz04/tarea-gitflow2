using System;

class Program
{
    static void Main(string[] args)
    {Console.WriteLine("***********************");
        Console.WriteLine("Holaaaa");
        Console.WriteLine("Adios desde la rama 'feature/agregar-despedida'");
        Console.WriteLine("Este es un saludoo desde la rama 'feature/agregar-saludo'.");
        Console.WriteLine("***********************");
        Console.WriteLine("Este saludo fue mejorado en la rama 'feature/mejorar-saludo'.");

        string nombre = Console.ReadLine();
        Console.WriteLine($"Holaaaaa {nombre}! Bienvenidoooo.");
        Console.WriteLine("Adios otra vez desde la rama feature/agregar-despedida!");
    }
}