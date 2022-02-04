using System;
using System.Linq;

namespace Recursive_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int ind = int.Parse(Console.ReadLine());
            Sum(ar, ind);
        }
        static int Sum(int[] array, int index)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }

            return array[index] + Sum(array, index + 1);
        }
    }

}
