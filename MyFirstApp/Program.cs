// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    public static void Main(string[] args)
    {
        string myName;
        myName = "Nikita";

        Console.WriteLine(myName);
        Console.WriteLine("\t \t Привет, Мир");
        Console.WriteLine("\t \t Мне 35 лет");
        Console.WriteLine("\t \t My name is \n {0}", myName);
        Console.WriteLine("\u0023");

        Console.ReadKey();

    }
}