using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the first number that is a multiple of all numbers 1-20.
    /// </summary>
    public class Problem5 : IProblem
    {
        public string Solve()
        {
            // There's probably a much better way to do this.
            for (long value = 1; value < long.MaxValue; value++)
            {
                if (value % 10000000 == 0)
                {
                    Console.WriteLine($"Still Searching... {value}");
                }
                var found = true;
                for (int i = 1; i <= 20; i++)
                {
                    if (value % i != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    return $"FOUND! {value}";
                }
            }

            return "wtf how'd I get here";
        }
    }
}