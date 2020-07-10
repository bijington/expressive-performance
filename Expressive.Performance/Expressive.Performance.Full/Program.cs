using System;
using Expressive.Performance.Shared;

namespace Expressive.Performance.Full
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Expressive Performance Full test");

            new TestRun(5).Run();

            Console.WriteLine("Completed");
            Console.Read();
        }
    }
}
