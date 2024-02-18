using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        for (int i = 0; i < 5; i++)
        {
            Console.Write("要素{0}を入力してください: ", i + 1);
            string? value = Console.ReadLine();
            if (string.IsNullOrEmpty(value)) continue;
            numbers.Add(int.Parse(value));
        }

        Console.WriteLine("入力された要素:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // 要素の追加
        numbers.Add(11);

        // 要素の削除
        numbers.Remove(5);

        // 要素の検索
        if (numbers.Contains(3))
        {
            Console.WriteLine("要素3は存在します");
        }
        else
        {
            Console.WriteLine("要素3は存在しません");
        }
    }
}
