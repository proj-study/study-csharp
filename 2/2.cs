using System;

namespace DocumentationExample
{
    /// <summary>
    /// Simple calculator for performing basic arithmetic operations.
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Adds two integers and returns the result.
        /// </summary>
        /// <param name="a">The first addend.</param>
        /// <param name="b">The second addend.</param>
        /// <returns>The sum of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts the second integer from the first and returns the result.
        /// </summary>
        /// <param name="a">The minuend.</param>
        /// <param name="b">The subtrahend.</param>
        /// <returns>The difference of <paramref name="a"/> and <paramref name="b"/>.</returns>
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    /// <summary>
    /// Entry point of the program.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3)); // Outputs: 8
            Console.WriteLine(calc.Subtract(5, 3)); // Outputs: 2
        }
    }
}