using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] saveNumber = new int[input];
            

            for (int i = 0; i < input; i++)
            {
                string name = Console.ReadLine();
                int sum = 0;

                for (int a = 0; a < name.Length; a++)
                {
                    char value = name[a];
                    int numberAssciChar = (int)value;
                    switch (value)
                    {
                        case 'A':
                        case 'a':
                        case 'E':
                        case 'e':
                        case 'I':
                        case 'i':
                        case 'O':
                        case 'o':
                        case 'U':
                        case 'u':
                            numberAssciChar = numberAssciChar * name.Length;
                            break;
                        default:
                            numberAssciChar = numberAssciChar / name.Length;
                            break;

                    }
                    sum += numberAssciChar;

                }
                saveNumber[i] = sum;
            }

            Array.Sort(saveNumber);
            foreach (int item in saveNumber)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}