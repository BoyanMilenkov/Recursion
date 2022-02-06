using System;
using System.Linq;

namespace nested_loops_to_recursion
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;
        static void Main(string[] args)
        {
           
            numberOfLoops = int.Parse(Console.ReadLine());
            //Console.Write("K = ");
            //numberOfIterations = int.Parse(Console.ReadLine());
            //numberOfIterations = numberOfLoops;
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }
        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfLoops; counter++)
            {

                loops[currentLoop] = counter;

                NestedLoops(currentLoop + 1);

            }

        }
        static void PrintLoops()

        {

            for (int i = 0; i < numberOfLoops; i++)

            {

                Console.Write("{0} ", loops[i]);

            }

            Console.WriteLine();

        }
    }
}
