using System;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int[] fibonaciSiquenc = new int[] { 1, 1 };
            int sum = 0;


            if (input == 1)
            {
                Console.WriteLine("1");
                return;
            }

            for (int i = 2; i < input; i++)
            {

                sum = fibonaciSiquenc[0] + fibonaciSiquenc[1];
                int[] newArray = new int[] { fibonaciSiquenc[1], sum };
                fibonaciSiquenc = newArray;
            }


            Console.Write(sum);

        }
    }
}
