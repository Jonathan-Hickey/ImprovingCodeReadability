using System;

namespace ImprovingCodeReadability
{

    //https://codereview.stackexchange.com/questions/253600/a-program-that-uses-three-methods-to-reverse-and-print-an-array
    class Program
    {
        static void Main(string[] args)
        {
            string getnums = Console.ReadLine();
            int getnum = Convert.ToInt32(getnums);
            int[] array1 = new int[getnum];

            GenerateNum(getnum, array1);
            RevArray(array1);
            PrintArray(array1);
        }
        static int[] GenerateNum(int getnums, int[] array)
        {

            for (int index = 0; index < getnums; index++)
            {
                array[index] = index;
            }
            return array;
        }
        static int[] RevArray(int[] array)
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
