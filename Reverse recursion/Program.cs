using System;
using System.Linq;

namespace Reverse_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            ReverseArray(array, array.Length - 1);
        }

        private static void ReverseArray(int[] array, int v)
        {
            if (v < 0) { return; }
            Console.Write(array[v] + "");
            ReverseArray(array, v - 1);
           
        }
    }
}
