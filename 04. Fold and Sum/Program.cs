using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] firstNumber = new int[number.Length / 2];
            int[] middleNumber = new int[number.Length / 2];

            int[] sum = new int[number.Length/2];
            for (int i = 0; i < firstNumber.Length / 2; i++)
            {

                firstNumber[i] = number[firstNumber.Length / 2 - i - 1];
                firstNumber[i + firstNumber.Length / 2] = number[number.Length - 1 - i];
            }

            for (int i = 0; i < number.Length / 2; i++)
            {

                middleNumber[i] = number[firstNumber.Length / 2 + i];

            }

            for (int i = 0; i < number.Length / 2; i++)
            {
                sum[i] = firstNumber[i] + middleNumber[i];
                Console.Write(sum[i] + " ");
            }
        }
    }
}