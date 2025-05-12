
namespace CatalanaCounterCSharp
{
    internal static class Program
        {
            static void Main()
            {
                Console.WriteLine("Hello, World!");
                Console.WriteLine(ParenthesisCombinations.CountWellFormedParenthesis(2));
            }
        }
    }
    public static class ParenthesisCombinations
    {
        public static int CountWellFormedParenthesis(int n)
        {
            if (n < 0 || n % 2 != 0 || n > 16)
                throw new ArgumentException("Invalid input");

            return CatalanNumber(n / 2);
        }

        private static int CatalanNumber(int n)
        {
            // C(n) = (2n)! / ((n + 1)! * n!)
            return (int)(Factorial(2 * n) / (Factorial(n + 1) * Factorial(n)));
        }

        private static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }
    }
