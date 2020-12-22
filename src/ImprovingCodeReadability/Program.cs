using System;

namespace ImprovingCodeReadability
{

    //https://codereview.stackexchange.com/questions/253600/a-program-that-uses-three-methods-to-reverse-and-print-an-array
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int arrayLength = Convert.ToInt32(input);
            
            var array = CreateArrayFilledWithNumbers(arrayLength);
            ReverseArray(array);
            PrintArray(array);
        }

        static int[] CreateArrayFilledWithNumbers(int arrayLength)
        {
            int[] array = new int[arrayLength];
            for (int index = 0; index < array.Length; index++)
            {
                array[index] = index;
            }
            return array;
        }

        static int[] ReverseArray(int[] array)
        {
            for (int index = 0; index < (array.Length) / 2; index++)
            {
                int a = array[index];
                array[index] = array[array.Length - index - 1];
                array[array.Length - index - 1] = a;
            }
            return array;
        }
        static void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(",", array));
        }
    }
}
