using System;

namespace Expressive.Performance.Shared
{
    public class TestRun
    {
        private readonly int numberOfTests;

        public TestRun(int numberOfTests)
        {
            this.numberOfTests = numberOfTests;
        }

        public void Run()
        {
            for (var i = 0; i < this.numberOfTests; i++)
            {
                Console.WriteLine($"Run {i}");

                var runner = new Test(10000, 3);

                var results = runner.Execute();

                foreach (var result in results)
                {
                    Console.WriteLine($"Evaluation took: {result}");
                }

                Console.WriteLine();
            }
        }
    }
}
