using System;
using static ProjectEuler.ProjectEuler;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the Pythagorean Triple whose sum is 1000.
    /// </summary>
    public class Problem9 : IProblem
    {
        public string Solve()
        {
            for (var a = 1; a < 1000; a++)
            {
                for (var b = a; b < 1000; b++)
                {
                    long cSquared = a * a + b * b;
                    var c = PerfectSqrt(cSquared);
                    if (c == -1) continue;

                    if (a + b + c == 1000)
                    {
                        return $"a:{a}, b:{b}, c:{c} product:{a * b * c}";
                    }
                }
            }

            return ":(";
        }
    }
}