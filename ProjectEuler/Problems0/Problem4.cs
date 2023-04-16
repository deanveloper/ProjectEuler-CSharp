using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the largest palindrome number that is the product of two three-digit numbers.
    /// </summary>
    public class Problem4 : IProblem
    {
        public string Solve()
        {
            var largest = 0;
            for (int x = 999; x > 100; x--)
            {
                for (int y = 999; y > x; y--)
                {
                    var num = x * y;
                    if (num.ToString().Flip().Equals(num.ToString()) && largest < num)
                    {
                        largest = num;
                    }
                }
            }

            return largest.ToString();
        }
    }
}