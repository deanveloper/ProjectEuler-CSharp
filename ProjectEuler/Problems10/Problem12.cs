using System;
using System.Linq;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Find the first triangle number with at least 500 divisors.
    /// </summary>
    public class Problem12 : IProblem
    {
        public string Solve()
        {
            uint triangleNumber = 0;
            for (uint i = 0; i < 500; i++)
            {
                triangleNumber += i;
            }
            for (uint i = 500; i < uint.MaxValue; i++)
            {
                // Update the triangle number.
                triangleNumber += i;

                // Solve for its divisors.
                var divisors = 0;
                for (uint x = 1; x < Math.Sqrt(triangleNumber); x++)
                {
                    uint div = triangleNumber.DivideEvenly(x);
                    if(div == 0) continue;
                    divisors += 2;
                }

                if (divisors >= 500)
                {
                    return $"i:{i} num:{triangleNumber} divisors:{divisors}";
                }

                if (i % 100 == 0)
                {
                    Console.WriteLine($"Scanning... i:{i} num:{triangleNumber} divisors:{divisors}");
                }
            }

            return ":(";
        }
    }
}