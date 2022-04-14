using System;
using System.Threading;
using System.Drawing;
using System.Timers;

namespace klok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            bool klok = true;
            while (klok == true)
            {
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
                Console.Clear();


            }
        }

    }
}
