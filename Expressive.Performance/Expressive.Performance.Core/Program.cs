using System;
using Expressive.Performance.Shared;

namespace Expressive.Performance.Core
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Expressive Performance Core test");

            new TestRun(5).Run();

            Console.WriteLine("Completed");
            Console.Read();
        }
    }
}
