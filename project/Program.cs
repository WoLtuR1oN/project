using System.Globalization;
using System.Net;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Однострочные комментарии
            // Создание переменной
            // тип_данных имя_переменной = значение;

            // Типы вывода информации в консоль
            /*int age = 25;
            string name = "Dima";*/
            // Ctrl + Shift + / - Комментирование выделенного кода многострочным комментарием

            // Вывод информации в консоль с использованием конкатенации строк
            // Не рекомендуется использовать конкатенацию строк для вывода информации в консоль, из-за переполнения памяти и снижения производительности.
            // Console.WriteLine("Hello, my name is " + name + " and I am " + age + " years old.");

            // Вывод информации в консоль с форматированием строк
            // Console.WriteLine("Hello, my name is {0} and I am {1} years old.", name, age);

            // Вывод информации в консоль с использованием интерполяции строк
            // Рекомендуется использовать интерполяцию строк для вывода информации в консоль, так как она более читаема и удобна в использовании.
            // Console.WriteLine($"Hello, my name is {name} and I am {age} years old.");

            // В С# используется кодировка UTF-16, которая поддерживает все символы Юникода, включая эмодзи. Поэтому можно использовать эмодзи в строках и выводить их в консоль.
            // Символы этой кодировки занимают 2 байта.
            // string name = "Dima";

            /*
            Console.Write("Введите имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Введите рост: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Введите ваш пол (1 - мужской, 2 - женский): ");
            int gender = int.Parse(Console.ReadLine());

            Console.Write("Вам есть 18 лет? Ответ: ");
            bool isAdult = bool.Parse(Console.ReadLine());
            */

            // \n - символ новой строки, который используется для переноса текста на следующую строку.
            // \t - символ табуляции, который используется для выравнивания текста по горизонтали.
            // \r - символ возврата каретки, который используется для возврата курсора в начало строки.
            // \\ - символ обратного слэша, который используется для экранирования специальных символов.
            // \" - символ двойной кавычки, который используется для экранирования двойных кавычек в строках.

            /*
            Console.WriteLine("\nРезультат анкеты:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Рост: {height}");
            Console.WriteLine($"Пол: {(gender == 1 ? "Мужской" : "Женский")}"); // Используется тернарный оператор для определения пола
            Console.WriteLine($"Совершеннолетний: {isAdult}");
            */

            // Домашнее задание:
            /*
             * 1. Почитать про системы счисления.
             * 2. Написать программу с анкетой, которая будет запрашивать у пользователя какие-то данные.
             * 3. Почитать про математические операторы и написать программу, которая решает след. математические выражения
             * Выражения на скриншоте в телеграмм
             */


            // Домашнее задание:


            // 1. Почитать про системы счисления.
            Console.Write("BINARY: ");
            int number = 255; // Восемь единиц

            string binary = Convert.ToString(number, 2);

            Console.WriteLine(binary);

            // 2. Написать программу с анкетой, которая будет запрашивать у пользователя какие-то данные.  

            Console.Write("\nSURVEY: ");


            // Name
            Console.Write("\nWhat is your name? ");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("Please enter a valid name: ");
                name = Console.ReadLine();
            }


            // Age
            Console.Write("How old are you? ");
            string input = Console.ReadLine();
            int age = 0;

            while (!int.TryParse(input, out age) || age < 0)
            {
                Console.Write("Please enter a valid age: ");
                input = Console.ReadLine();
            }


            // Gender
            Console.Write("What is your gender? 1 - Male, 2 - Female: ");
            string answer = (Console.ReadLine());
            string gender = "";

            while (answer != "1" && answer != "2")
            {
                Console.Write("Please enter a valid answer (1 or 2): ");
                answer = Console.ReadLine();
            }
            gender = (answer == "1") ? "Male" : "Female";


            // Height
            Console.Write("How tall are you? ");
            string heightInput = Console.ReadLine();
            float height = 0;

            while (!float.TryParse(heightInput, out height) || height < 0)
            {
                Console.Write("Please enter a valid height: ");
                heightInput = Console.ReadLine();
            }


            // Student
            Console.Write("Are you a student? true/false: ");
            string studentInput = Console.ReadLine();
            bool isStudent = false;

            while (!bool.TryParse(studentInput, out isStudent))
            {
                Console.Write("Please enter true or false: ");
                studentInput = Console.ReadLine();
            }


            // Favorite letter
            Console.Write("What is your favorite letter? ");
            string letterInput = Console.ReadLine();

            char favoriteLetter = '\0';

            while (!char.TryParse(letterInput, out favoriteLetter))
            {
                Console.Write("Please enter exactly one character: ");
                letterInput = Console.ReadLine();
            }


            // Output the survey results
            Console.WriteLine($"\nHello, {name}!");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Student: {isStudent}");
            Console.WriteLine($"Favorite letter: {favoriteLetter}");


            // 3. Почитать про математические операторы и написать программу, которая решает след. математические выражения

            Console.Write("\nnumber a: ");
            double a = double.Parse(
            Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

            Console.Write("number b: ");
            double b = double.Parse(Console.ReadLine()!.Replace(',', '.'), CultureInfo.InvariantCulture);

            double result1 = (a - 1) / (b + 1);
            double result2 = ((b + a) * a) / 2;
            double result3 = (a % b) + Math.Pow(a, b);

            Console.WriteLine($"\nfirst: {result1}");
            Console.WriteLine($"second: {result2}");
            Console.WriteLine($"third: {result3}");
        }
    }
}