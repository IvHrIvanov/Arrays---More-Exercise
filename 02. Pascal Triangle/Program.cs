using System;

namespace _02._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] currentArr = { 1 };

            for (int i = 1; i <= input; i++)
            {
                int[] nextArray = new int[currentArr.Length + 1];

                for (int a = 0; a < currentArr.Length; a++)
                {
                    nextArray[a] += currentArr[a];

                    nextArray[a + 1] += currentArr[a];

                    Console.Write(currentArr[a] + " ");

                }
                Console.WriteLine();

                currentArr = nextArray;
            }
        }
    }
}