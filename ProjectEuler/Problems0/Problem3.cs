using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the largest prime multiple of 600851475143.
    /// </summary>
    public class Problem3 : IProblem
    {
        public string Solve()
        {
            const long num = 600851475143;
            long largest = 0;

            for (long i = 1; i * i <= num; i++)
            {
                // if num is a factor and the number is prime
                if (num % i == 0 && i.IsPrime())
                {
                    largest = Math.Max(largest, num);
                }
            }

            return largest.ToString();
        }
    }
}