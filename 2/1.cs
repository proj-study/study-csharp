using System;

namespace CustomException
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string message) : base(message) { }
    }

    class BigNumberException : Exception
    {
        public BigNumberException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a positive number:");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number < 0)
                {
                    throw new NegativeNumberException("Number is not positive.");
                }
                if (number > 10)
                {
                    throw new BigNumberException("Number is too big.");
                }
                Console.WriteLine("You entered a positive number.");
            }
            catch (BigNumberException ex)
            {
                Console.WriteLine("Big Number Error: " + ex.Message);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Negative Number Error: " + ex.Message);
            }
        }
    }
}