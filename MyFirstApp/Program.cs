using System;
using System.Globalization;

class MainClass
{
    public static void Main(string[] args)
    {

    (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;


        for (int a = 0; a < 3; a++)

        {
            Console.WriteLine("Введите имя: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Введите логин: ");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да/Нет.");
            if (Console.ReadLine() == "Да")
                User.HasPet = true;
            else
                User.HasPet = false;

            Console.WriteLine("Введите возраст пользователя: ");
            User.Age = Convert.ToDouble(Console.ReadLine());

            User.favcolors = new string[3];
            Console.WriteLine("Введите три любимых цвета пользователя: ");
            for (int i = 0; i < User.favcolors.Length; i++)
            {
                User.favcolors[i] = Console.ReadLine();
            }
        }
    }
}