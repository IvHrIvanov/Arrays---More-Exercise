using System;

namespace arrayAddSpot
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] currentArr = { 1 };
            for (int i = 0; i < 10; i++)
            {
                int[] nextArray = new int[currentArr.Length + 1];
                currentArr = nextArray;
            }
        }
    }
}
