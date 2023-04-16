using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the sum of all multiples of 3 or 5 less than or equl to 1000.
    /// </summary>
    public class Problem1 : IProblem
    {
        public string Solve()
        {
            var sum = 0;
            for (var i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum.ToString();
        }
    }
}