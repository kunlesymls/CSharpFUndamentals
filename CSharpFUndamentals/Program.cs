using System;

namespace CSharpFUndamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string answ = string.Empty;
            bool canCovert;

            do
            {
                Console.WriteLine("Please enter any number");

                canCovert = int.TryParse(Console.ReadLine(), out int number);
                if (canCovert != false)
                {
                    AddNumbers(number, out int sum);

                    Console.WriteLine($"Sum of all number for 1  to {number} is equal {sum}");
                    Console.WriteLine("Press Y to continue and any other key to exit");
                    answ = Console.ReadLine();
                    sum = 0;
                }

                Console.WriteLine("Please type in a number and not alphabet");
            }
            while (answ.ToLower() == "y" || !canCovert);
        }

        private static void AddNumbers(int number, out int sum)
        {
            int newSum = 0;
            for (int i = 0; i <= number; i++)
            {
                newSum += i;
            }
            sum = newSum;
        }
    }
}
