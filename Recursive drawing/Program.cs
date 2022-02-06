using System;

namespace Recursive_drawing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Draw(n);
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
