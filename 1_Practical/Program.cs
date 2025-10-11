//Task 1

//using System;

//namespace _1_Practical
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
//        }
//    }
//}

//Task 2

using System;

using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[5];
        Console.WriteLine("Введіть 5 чисел:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Число {i + 1}: ");
            numbers[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        double product = 1;
        double max = numbers[0];
        double min = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            product *= numbers[i];

            if (numbers[i] > max)
                max = numbers[i];

            if (numbers[i] < min)
                min = numbers[i];
        }

        Console.WriteLine("\nРезультати обчислень:");
        Console.WriteLine($"Сума чисел: {sum}");
        Console.WriteLine($"Добуток чисел: {product}");
        Console.WriteLine($"Максимальне число: {max}");
        Console.WriteLine($"Мінімальне число: {min}");
    }
}