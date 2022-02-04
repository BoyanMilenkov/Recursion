using System;

namespace Recursive_drawing
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw(5);
        }
        private static void Draw(int v)
        {
            if(v == 0)
            {
                return;
            }
            Console.WriteLine(new string('*', v));
            Draw(v - 1);
            Console.WriteLine(new string('#', v));
        }
    }
}
