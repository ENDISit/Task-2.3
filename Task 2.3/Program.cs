using System;

class Program
{
    static void Main()
    {
        string[] strings = { "apple", "banana", "cherry", "date", "fig", "grape" };

        Console.Write("Введите строку для поиска: ");
        string inputString = Console.ReadLine();

        bool found = false;
        foreach (string str in strings)
        {
            if (str == inputString)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }

        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
