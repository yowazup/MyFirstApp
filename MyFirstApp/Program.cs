// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

class MainClass
{
    public static void Main(string[] args)
    { 
    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
		
	var color = Console.ReadLine();

		if (color == "red")
		{
		Console.BackgroundColor = ConsoleColor.Red;
		Console.ForegroundColor = ConsoleColor.Black;

		Console.WriteLine("Your color is red!");
		}

        else if (color == "green")
        {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Your color is green!");
        }
        
        else
        {
        Console.BackgroundColor = ConsoleColor.Cyan;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.WriteLine("Your color is cyan!");
        }
    }
}