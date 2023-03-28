using System;

namespace VirtueltKjaeledyr;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the pet generator");

        var pets = new Pets();
        var menu = new Menu(pets);

        menu.Run();
    }
}