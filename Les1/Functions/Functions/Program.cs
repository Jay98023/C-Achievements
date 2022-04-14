using System;


namespace FunctionS
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipString("Hello World!");
        }

        private static void FlipString(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine((chars));
        }
    }
}