using System;

namespace Switch_Cases
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int nummer))
                {
                    switch (nummer)
                    {
                        case 0:
                            Console.WriteLine("Hallo, je hebt een 0 ingevoerd");
                            break;
                        case 1:
                            Console.WriteLine("Hallo, je hebt een 1 ingevoerd");
                            break;
                        default:
                            Console.WriteLine("hallo, dit is de default case: " + nummer);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Voer een nummer in A.U.B");
                }

                Console.WriteLine("");
            }
        }
    }
}
