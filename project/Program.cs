using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Globalization;
namespace project

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Однострочные комментарии
            // Создание переменной
            // тип_данных имя_переменной = значение;

            // Создание переменной и ее инициализация
            // int number = 42;

            // Создание переменной без инициализации
            // int number;
            Console.Write("Hi! ");

            Console.Write("Enter your name: ");

            string name = Console.ReadLine();
            Console.WriteLine($"Your name is: {name}"); // Интерполяция строк

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is: " + age); // Конкатенация строк

            /* Типы данных в C#:
             * int - целое число = 42;
             * double - дробные числа = 3.14;
             * string - текст
             * bool - логический тип (true/false)
             */


            // Личные заметки:
            /*
            * Типы данных:
            * Знаковые целочисленные типы данных:
            * sbyte - от -128 до 127 (1 байт)
            * short - от -32 тыс. до 32 тыс. (2 байта)
            * int - от -2,1 млрд до 2,1 млрд (4 байта)
            * long - примерно от -9,2 квинтиллиона до 9,2 квинтиллиона (8 байт)
            * 
            * Беззнаковые целочисленные типы данных:
            * byte - от 0 до 255 (1 байт)
            * ushort - от 0 до 65 тыс. (2 байта)
            * uint - от 0 до 4,29 млрд (4 байта)
            * ulong - от 0 до 18,4 квинтиллиона (8 байт)
            * 
            * Типы с плавающей запятой:
            * float - дробные числа, точность 6-9 цифр (4 байта), пример: 3.14f
            * double - дробные числа, точность 15-17 цифр (8 байт), пример: 3.14
            * decimal - высокая точность, для денежных расчётов (16 байт), пример: 3.14m
            * 
            * Булевый тип:
            * bool - true/false
            * 
            * Строковые типы:
            * char - один символ в одинарных кавычках (2 байта), пример: 'A'
            * string - текст в двойных кавычках, пример: "Привет"
            * 
            * Ввод и вывод консоли:
            * Console.WriteLine() - вывод текста с переходом на новую строку
            * Console.Write() - вывод текста без перехода на новую строку
            * Console.ReadLine() - считывание введённой пользователем строки
            * 
            * Преобразование типов данных:
            * int.Parse() - преобразует текст в целое число
            * float.Parse() - преобразует текст в float
            * double.Parse() - преобразует текст в double
            * decimal.Parse() - преобразует текст в decimal
            * 
            * Parse() выдаст ошибку, если текст нельзя преобразовать в число.
            * Parse() используется для преобразования строк в числовые типы данных.
            * float использует суффикс f, decimal использует суффикс m.
            */


            // Личные тесты:
            Console.WriteLine();
            Console.WriteLine("Личные тесты:");

            int number = int.Parse("123");
            Console.WriteLine(number + 10);
            Console.WriteLine("123" + "10");

            int number2 = int.Parse("113");
            Console.WriteLine(number2 + 10);
            Console.WriteLine("113" + "10");

            int number3 = int.Parse("123");
            Console.WriteLine(number3 + 10);
            Console.WriteLine("123" + "10");

            string text = "1111,1";
            float number4 = float.Parse(text);
            Console.WriteLine(number4);

            byte smallnumber1 = 77;
            Console.WriteLine("У меня " + smallnumber1 + " евро в кошельке");

            int hours = 25;
            Console.WriteLine("У меня " + hours + " часов" + " в игре");

            int hours1 = 17;
            Console.WriteLine("У меня " + hours1 + " часов в игре");

            long bignumber = 1234567890123456789L;
            Console.WriteLine("Хотел бы я себе зарплату " + bignumber + " евро");

            short smallnumber = 31000;
            Console.WriteLine("У друга " + smallnumber + " долларов должок передо мной");

            ushort smallnumber2 = 52000;
            Console.WriteLine("Я положил в банк " + smallnumber2 + " гривны");

            bool trueorfalse = false;
            Console.WriteLine("Правда ли, что 2 + 2 = 1? " + trueorfalse);

            Console.WriteLine(
                "Типы данных: Знаковые: sbyte -128 до 127, short -32000 до 32000, int -2,1m до 2,1m, long -9,2m до 9,2m" 
                );
            Console.WriteLine(
                "Типы данных: Беззнаковые: byte 0 до 255, ushort 0 до 64000, uint 0 до 4,2m, ulong o до 18,4m"
                );

            // Домашнее задание:
            // В программе создайте переменные следующих типов данных:
            Console.WriteLine();
            Console.WriteLine("Домашнее задание:");
            string name1 = "Дмитрий";
            int age1 = 17;
            double height1 = 1.75;
            char favouriteletter = 'Ф';
            bool likesprogramming = true;
            Console.WriteLine("Имя: " + name1);
            Console.WriteLine("Возраст: " + age1);
            Console.WriteLine("Рост: " + height1);
            Console.WriteLine("Любимая буква: " + favouriteletter);
            Console.WriteLine("Любит программирование: " + likesprogramming);

            // Второй вариант:
            Console.WriteLine();
            Console.WriteLine("Второй вариант:");
            string name2 = "Александр";
            int age2 = 18;
            float height2 = 1.80f;
            char gender2 = 'М';
            bool likesprogramming1 = true;
            Console.WriteLine(
                "Вас зовут " + name2 + " и вам " + age2 + " лет" + " ростом: " + height2 + " метра" + ", пол: " + gender2 + ", любит программирование: " + likesprogramming1);

            // Личные изучения:
            Console.WriteLine();
            Console.WriteLine("Личные изучения:");
            Console.WriteLine("Сколько вам лет?");
            int number5 = int.Parse(Console.ReadLine());
            if (number5 > 25)
            {
                Console.WriteLine("Ты взрослый");
            }
            else
            {
                Console.WriteLine("Ты ещё молодой");
            }
            Console.WriteLine("У вас есть 124.25 гривны? yes/no");
            string hasmoney = Console.ReadLine();
            if (hasmoney == "да" || hasmoney == "yes")
            {
                Console.WriteLine("Тебе хватает денег");
            }
            else
            {
                Console.WriteLine("Тебе не хватает денег");
            
            }
        }
    }
}