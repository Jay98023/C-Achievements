using System;

using Dog;
using Paw;

namespace Les5Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dogs dog = new Dogs();

            Paws paw = dog.GetPaw();
            paw.Clean();

            Console.WriteLine(paw.IsClean());
        }
    }
}
