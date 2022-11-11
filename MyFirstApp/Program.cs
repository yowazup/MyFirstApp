using System;
using System.Globalization;

class MainClass
{

    static void Main(string[] args)
    {
        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();

        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());

        Console.WriteLine(str);

        Echo(str, deep);

        Console.ReadKey();
    }

    static void Echo(string saidword, int deep)
    {
        var modif = saidword;

        if (modif.Length >= 2)
        {
            modif = modif.Remove(0, 2);
        }

        if (modif.Length < 2)
        {
            Console.WriteLine("win-win-win-win");
            
            return;
        }
        
        if (deep >= 15)
        {
            deep = 14;
        }

        Console.BackgroundColor = (ConsoleColor)deep;
        Console.WriteLine("..." + modif);

        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }

    }
}