using System;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace BinarySearch
{
    class Program
    {
        private static int BinarySearch(ref int[] array, int valueToFind)
        {
            int middle;
            int middleNumber;
            int begin = 0;
            int end = array.Length - 1;
            while(!(begin > end))
            {
                middle = (begin + end) / 2;
                middleNumber = array[middle];
                if (middleNumber == valueToFind)
                {
                    return middleNumber;
                }
                else if (middleNumber > valueToFind)
                {
                    end = middle - 1;
                }
                else if (middleNumber < valueToFind)
                {
                    begin = middle + 1;
                }
            }
            throw new ArgumentException("No such number.");
        }
        static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4, 5 ,6};
            Console.WriteLine(BinarySearch(ref array, 1));
            Console.WriteLine(BinarySearch(ref array, 5));
            Console.WriteLine(BinarySearch(ref array, 6));
            Console.WriteLine(BinarySearch(ref array, 7));
        }
    }
}
