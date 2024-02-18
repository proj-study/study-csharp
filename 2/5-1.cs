using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("要素{0}を入力してください: ", i + 1);
            string? value = Console.ReadLine();
            if (string.IsNullOrEmpty(value)) continue;
             numbers[i] = int.Parse(value);
        }

        Console.WriteLine("入力された要素:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        int max = int.MinValue;
        int min = int.MaxValue;

        foreach (var number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine("最大値: {0}", max);
        Console.WriteLine("最小値: {0}", min);
    }
}
