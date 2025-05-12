
using System.Diagnostics;

using Xunit.Abstractions;

namespace CatalanaCounterCSharp.Tests
{
    public class TestLoad(ITestOutputHelper testOutputHelper)
    {
        private double MeasureAverageTime(int iterations, Action action)
        {
            long totalTime = 0;

            for (int i = 0; i < iterations; i++)
            {
                var stopwatch = Stopwatch.StartNew();
                try
                {
                    action();
                }
                catch
                {
                    // ignored
                }

                stopwatch.Stop();
                totalTime += stopwatch.ElapsedMilliseconds;
            }

            return totalTime / (double)iterations;
        }

        [Theory]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(16)]
        public void PerformanceTest_ValidInputs(int input)
        {
            double avgTime = MeasureAverageTime(15, () =>
                ParenthesisCombinations.CountWellFormedParenthesis(input));

            testOutputHelper.WriteLine($"Average time for valid n={input}: {avgTime} ms");

            Assert.True(avgTime < 1000, $"Performance too slow for valid n={input}, average time: {avgTime} ms");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(3)]
        [InlineData(100)]
        public void PerformanceTest_InvalidInputs(int input)
        {
            double avgTime = MeasureAverageTime(15, () =>
                {
                    try
                    {
                        ParenthesisCombinations.CountWellFormedParenthesis(input);
                    }
                    catch (ArgumentException)
                    {
                       
                    }
                });

            testOutputHelper.WriteLine($"Average time for invalid n={input}: {avgTime} ms");

            Assert.Throws<ArgumentException>(() =>
                ParenthesisCombinations.CountWellFormedParenthesis(input));
        }
    }
}
