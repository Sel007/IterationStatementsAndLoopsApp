using System;

namespace IterationStatementsAndLoopsConsuleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            //while (i < 10);
            //{
            //Console.WriteLine("Hello World!");
            // i++;
            //}

            //do
            //{
            //Console.WriteLine("Hello World!");
            //i++;
            //}

            int[] numbers = { 1, 2, 1, 2, 1, 2, };

            //for (int j = 0; j < numbers.length; j++)

            //    numbers[j] += 1;
            //{
            //    Console.WriteLine($"{numbers[j]} is the {j} index in the array");
            //}

            foreach (int number in numbers)
            {
                ConsoleWriteLine($"{numbers}");
            }



        }
    }
}
