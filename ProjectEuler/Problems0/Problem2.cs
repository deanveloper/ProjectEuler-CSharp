using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the sum of all even fibonacci numbers under 4000000.
    /// </summary>
    public class Problem2 : IProblem
    {
            public string Solve()
            {
                return Fibonacci(0, 1, 0).ToString();
            }

            int Fibonacci(int previous, int next, int sum)
            {
                if (next > 4000000) return sum;

                if (next % 2 == 0)
                {
                    sum += next;
                }
                return Fibonacci(next, next + previous, sum);
            }
    }
}