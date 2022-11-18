using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

class Program
{

    static void Main(string[] args)
    {
        (string Name, string Surname, int Age, string AnyPets, int PetsCount, string[] PetsNames, int ColorsCount, string[] ColorsNames) Form;

        Console.WriteLine("Введите Ваше имя: ");
        Form.Name = Console.ReadLine();

        Console.WriteLine("Введите Вашу фамилию: ");
        Form.Surname = Console.ReadLine();

        Console.WriteLine("Введите Ваш возраст: ");
        Form.Age = int.Parse(Console.ReadLine());
        
            while (Form.Age <= 0)
            {
                Form.Age = Check();
            }

        Console.WriteLine("У вас есть питомцы? ");
        Form.AnyPets = Console.ReadLine();

        if (Form.AnyPets == "Да" || Form.AnyPets == "да")
        {
            Console.WriteLine("Сколько у вас питомцев? ");

            Form.PetsCount = int.Parse(Console.ReadLine());

            while (Form.PetsCount <= 0)
            {
                Form.PetsCount = Check();
            }

            Form.PetsNames = new string[Form.PetsCount];

            for (int i = 0; i < Form.PetsCount; i++)
            {
                Console.WriteLine("Введите имя питомца {0}: ", i + 1);
                Form.PetsNames[i] = Console.ReadLine();
            }
        }
        else
        {
            Form.PetsCount = 0;
            Form.PetsNames = new string[Form.PetsCount];
        }


        Console.WriteLine("Сколько у вас любимых цветов? ");
        Form.ColorsCount = int.Parse(Console.ReadLine());

            while (Form.ColorsCount <= 0)
            {
              Form.ColorsCount = Check();
            }

            Form.ColorsNames = new string[Form.ColorsCount];

                for (int i = 0; i < Form.ColorsCount; i++)
                {
                Console.WriteLine("Введите любимый цвет {0}: ", i + 1);
                Form.ColorsNames[i] = Console.ReadLine();
                }

        Print(Form.Name, Form.Surname, Form.Age, Form.AnyPets, Form.PetsCount, Form.PetsNames, Form.ColorsCount, Form.ColorsNames);

        Console.ReadKey();
    }

    static int Check()
    {
        Console.WriteLine("Вы ввели неверное значение. Ответ должен быть целым числом больше нуля. Введите правильное значение: ");

        int Correction = int.Parse(Console.ReadLine());
        return Correction;
    }

    static void Print(string Name, string Surname, int Age, string AnyPets, int PetsCount, string[] PetsNames, int ColorsCount, string[] ColorsNames)
    {
        Console.WriteLine("Ваше имя: {0}", Name);
        Console.WriteLine("Ваша фамилия: {0}", Surname);
        
        if (Age > 4)
        {
            Console.WriteLine("Вам {0} лет", Age);
        }
        else
        {
            Console.WriteLine("Вам слишком мало лет для этого задания :).");
        }

        if (AnyPets == "Да" || AnyPets == "да")
        {
            Console.WriteLine("У вас есть питомцы.");

            for (int i = 0; i < PetsCount; i++)
            {
                Console.WriteLine("Питомца {0} зовут: {1}", i + 1, PetsNames[i]);
            }
        }
        else
        {
            Console.WriteLine("У вас нет питомцев.");
        }

        for (int i = 0; i < ColorsCount; i++)
        {
            Console.WriteLine("Ваш любимый цвет {0}: {1}.", i + 1, ColorsNames[i]);
        }


    }

}