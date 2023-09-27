using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = -1;
        while (choice != 0)
        {
            Console.WriteLine("Выберите программу:");
            Console.WriteLine("1. Игра \"Угадай число\"");
            Console.WriteLine("2. Таблица умножения");
            Console.WriteLine("3. Вывод делителей числа");
            Console.WriteLine("0. Выход");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ugaday();
                    break;
                case 2:
                    tablicaprikolov();
                    break;
                case 3:
                    vivedimenya();
                    break;
                case 0:
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                    break;
            }
        }
    }

    static void ugaday()
    {
        Random random = new Random();
        int sekret = random.Next(0, 101);
        int guess = -1;
        int popitka = 0;
        while (guess != sekret)
        {
            Console.Write("Введите число от 0 до 100: ");
            guess = int.Parse(Console.ReadLine());
            attempts++;
            if (guess > sekret)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else if (guess < sekret)
            {
                Console.WriteLine("Загаданное число больше.");
            }
        }
        Console.WriteLine($"Вы угадали число {sekret} за {popitka} попыток.");
    }

    static void tablicaprikolov()
    {
        int[,] stol = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                stol[i, j] = (i + 1) * (j + 1);
            }
        }
        Console.WriteLine("Таблица умножения:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write($"{stol[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    static void vivedimenya()
    {
        int chislo = -1;
        while (chislo != 0)
        {
            Console.Write("Введите число (для выхода введите 0): ");
            chislo = int.Parse(Console.ReadLine());
            if (chislo != 0)
            {
                Console.Write($"Делители числа {chislo}: ");
                for (int i = 1; i <= chislo; i++)
                {
                    if (chislo % i == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}