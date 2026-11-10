namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Switch calculator

            /*
             * Задачи:
             * 1. Сумма
             * 2. Разница
             * 3. Умножение
             * 4. Деление
             */


            Console.WriteLine("Calculator");

            Console.Write("\nEnter first number: ");

            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");

            double secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSelect operation:");
            Console.WriteLine($"1. {"Addition",-16} (Сумма)");
            Console.WriteLine($"2. {"Subtraction",-16} (Разница)");
            Console.WriteLine($"3. {"Multiplication",-16} (Умножение)");
            Console.WriteLine($"4. {"Division",-16} (Деление)");

            Console.WriteLine();
            Console.Write("Enter your number: ");

            string operation = Console.ReadLine()!;

            switch (operation)
            {
                case "1":
                    Console.WriteLine($"\nResult: {firstNumber + secondNumber}");
                    break;
                case "2":
                    Console.WriteLine($"\nResult: {firstNumber - secondNumber}");
                    break;
                case "3":
                    Console.WriteLine($"\nResult: {firstNumber * secondNumber}");
                    break;
                case "4":
                    if (secondNumber != 0)
                    {
                        Console.WriteLine($"\nResult: {firstNumber / secondNumber}");
                    }
                    else
                    {
                        Console.WriteLine("You can't divide by zero!");
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid operation selected.");
                    break;
            }



            // 2. Weekly schedule

            /*
             * Порядковый номер:
             * 1. Понедельник
             * 2. Вторник
             * 3. Среда
             * 4. Четверг
             * 5. Пятница
             * 6. Суббота
             * 7. Воскресенье
             */

            Console.Write("---------");

            Console.Write("\nWeekly schedule");

            Console.Write("\n\nEnter the day number (1-7): ");

            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("\nMonday: Study, homework.");
                    break;

                case 2:
                    Console.WriteLine("\nTuesday: Study, walk.");
                    break;

                case 3:
                    Console.WriteLine("\nWednesday: Study, sports.");
                    break;

                case 4:
                    Console.WriteLine("\nThursday: Study, homework.");
                    break;

                case 5:
                    Console.WriteLine("\nFriday: Study, rest.");
                    break;

                case 6:
                    Console.WriteLine("\nSaturday: Cleaning, meeting with friends.");
                    break;

                case 7:
                    Console.WriteLine("\nSunday: Rest, preparation for the new week.");
                    break;

                default:
                    Console.WriteLine("\nThat day of the week doesn't exist!");
                    break;
            }
                    Console.Write("\nHave a good day! :)\n");

        }
    }
}