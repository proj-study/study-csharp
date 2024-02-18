using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            var divisibleByThree = numbers.Where(n => n % 3 == 0).ToList();

            Console.WriteLine("Even numbers:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Numbers divisible by three:");
            foreach (var n in divisibleByThree)
            {
                Console.WriteLine(n);
            }
        }
    }
}