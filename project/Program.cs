namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) Вычислить выражение:

            Console.WriteLine("Task 1:");

            // a) (3 + 5(6 + 3) - 8 * 3 + 1) / (21 + 50 / (3 + 4(1 + 2)))


            double result1 = (3 + 5 * (6 + 3) - 8 * 3 + 1.0) / (21.0 + 50.0 / (3 + 4 * (1 + 2)));

            Console.WriteLine($"a: {result1}");


            // b) ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / (3/7 + 2.97(8.05 - 8.1 * 6.07))

            double result2 = ((0.25 - 0.12) * 0.81 + 0.132 - 2.7 / 3.1) / (3.0 / 7 + 2.97 * (8.05 - 8.1 * 6.07));

            Console.WriteLine($"b: {result2}");


            //2) Ввести с клавиатуры 3 целых числа a, b и c и вывести значение выражения:

            Console.WriteLine("\nTask 2:");

            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine()!);

            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine()!);


            // a) a + b - c * (3ab + a^2) / (bc) - (c + ab / c)^2

            double result3 = a + b - (double)c * (3.0 * a * b + Math.Pow(a, 2)) / (double)(b * c) - Math.Pow(c + (double)a * b / c, 2);

            Console.WriteLine($"a: {result3}");

            // b) ((ab + 7c)^3 - (a^2 + b^2 + c^2)) / (b - ac - a(b + c))


            double result4 = (Math.Pow(a * b + 7.0 * c, 3) - (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2))) / (b - a * c - a * (b + c));

            Console.WriteLine($"b: {result4}");
        }
    }
}
