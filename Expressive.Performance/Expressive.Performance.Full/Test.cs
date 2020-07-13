using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Expressive.Performance.Shared
{
    public class Test
    {
        private readonly int numberCount;
        private readonly int evaluationCount;

        public Test(int numberCount, int evaluationCount)
        {
            this.numberCount = numberCount;
            this.evaluationCount = evaluationCount;
        }

        public IEnumerable<TimeSpan> Execute()
        {
            var result = new List<TimeSpan>();
            var builder = new StringBuilder();

            for (var i = 0; i < this.numberCount; i++)
            {
                if (builder.Length > 0)
                {
                    builder.Append(" + ");
                }

                builder.Append($"{i}");
            }

            var expression = new Expression(builder.ToString());

            var stopwatch = new Stopwatch();

            for (var i = 0; i < this.evaluationCount; i++)
            {
                stopwatch.Start();
                _ = expression.Evaluate();
                stopwatch.Stop();

                result.Add(stopwatch.Elapsed);
                stopwatch.Reset();
            }

            return result;
        }
    }
}
