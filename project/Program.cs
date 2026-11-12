namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Домашнее задание:
             * Решить задание через логическое И и логическое ИЛИ, и решить это же задания не используя логические операторы и switch.
             * 1) Требуется определить, является ли введенный пользователем год високосным
             * (напомним, что год является високосным, если его номер кратен 4, но не кратен 100, а также если он кратен 400).
             * 2) Даны три целых числа, которые пользователь вводит с клавиатуры. Найти количество положительных и количество отрицательных чисел в исходном наборе.
             */

            // Leap year (with && and ||)


            Console.Write("Leap Year");

            Console.Write("\n\nEnter a year:");
            int year = int.Parse(Console.ReadLine()!);

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }

            Console.Write("-----------");


            // Leap year (without && and || and switch)


            Console.Write("\nEnter a year:");
            int year2 = int.Parse(Console.ReadLine()!);

            if (year2 % 4 == 0)
            {
                if (year2 % 100 != 0)
                {
                    Console.WriteLine($"{year2} is a leap year.");
                }
                else
                {
                    if (year2 % 400 == 0)
                    {
                        Console.WriteLine($"{year2} is a leap year.");
                    }
                    else
                    {
                        Console.WriteLine($"{year2} is not a leap year.");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{year2} is not a leap year.");
            }
            Console.Write("-----------");


            // Leap year (with switch)


            Console.Write("\nEnter a year:");
            int year3 = int.Parse(Console.ReadLine()!);

            switch (year3 % 4)
            {
                case 0:
                    switch (year3 % 100)
                    {
                        case 0:
                            switch (year3 % 400)
                            {
                                case 0:
                                    Console.WriteLine($"{year3} is a leap year.");
                                    break;
                                default:
                                    Console.WriteLine($"{year3} is not a leap year.");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine($"{year3} is a leap year.");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine($"{year3} is not a leap year.");
                    break;
            }
        }
    }
}