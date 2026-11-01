using System;

namespace project;

class Program
{
    static void Main()
    {
        // 1. Ввод ставки
        Console.Write("Введите ставку от 5 до 100 долларов: ");

        string input = Console.ReadLine();

        if (!int.TryParse(input, out int bet) ||
            bet < 5 || bet > 100 || bet % 5 != 0)
        {
            Console.WriteLine("Ошибка! Некорректная ставка.");
            return;
        }

        // 2. Генерация трех случайных чисел
        Random random = new Random();

        int a = random.Next(1, 10);
        int b = random.Next(1, 10);
        int c = random.Next(1, 10);

        Console.WriteLine("\nБарабан:");
        Console.WriteLine($"{a} {b} {c}");

        // 3. Проверка выигрышной комбинации
        double coefficient = 0;
        string message = "";

        // Джекпот: 777
        if (a == 7 && b == 7 && c == 7)
        {
            coefficient = 150 * 1.5;
            message = "ДЖЕКПОТ!";
        }
        // Три одинаковых числа
        else if (a == b && b == c)
        {
            coefficient = a * 10 * 1.5;
            message = "Три одинаковых числа!";
        }
        // Первые два числа одинаковые, третье отличается
        else if (a == b && b != c)
        {
            coefficient = (a == 7 ? 15 : a) * 1.25;
            message = a == 7
                ? "Мини-джекпот!"
                : "Выигрышная пара!";
        }
        // Есть хотя бы одна семерка
        else if (a == 7 || b == 7 || c == 7)
        {
            coefficient = 1.6;
            message = "Есть семерка!";
        }
        // Есть хотя бы одна девятка
        else if (a == 9 || b == 9 || c == 9)
        {
            coefficient = 1.35;
            message = "Есть девятка!";
        }

        // 4. Вывод результата
        if (coefficient == 0)
        {
            Console.WriteLine("К сожалению, вы проиграли.");
        }
        else
        {
            double winnings = bet * coefficient;

            Console.WriteLine(message);
            Console.WriteLine($"Коэффициент: {coefficient:F2}");
            Console.WriteLine($"Ваш выигрыш: {winnings:F2} $");
        }

        Console.WriteLine("\nИгра завершена.");
    }
}
