// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.CodeAnalysis;

class MainClass
{
    public static void Main(string[] args)
    {
        //Ввод имени
        Console.Write("\n Enter your name: ");
        var name = Console.ReadLine();

        //Ввод даты рождения и преодбразование в формат даты
        Console.Write("\n Enter your birthdate: ");
        string inputdate = Console.ReadLine();
        int year = int.Parse(inputdate.Substring(6,4));
        int month = int.Parse(inputdate.Substring(3, 2));
        int day = int.Parse(inputdate.Substring(0, 2));
        var birthdate = new DateTime (year, month, day);

        //Расчет возраста
        DateTime today = DateTime.Today;        
        TimeSpan diff = today - birthdate;
        double longage = diff.TotalDays / 365.25;
        int age = (int) longage;
        
        //Вывод ответа
        Console.WriteLine("\n Hello, {0}. Today is {1} and your age is {2} years.", name, today.ToString("dd MMMM yyyy"), age);

        Console.ReadKey();

    }
}