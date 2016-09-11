using System;
using System.Collections.Immutable;
using System.Linq;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the 10001st prime number.
    /// </summary>
    public class Problem7 : IProblem
    {
        public string Solve()
        {
            // There are most likely 10001 primes under 1,000,000.
            var list = ProjectEuler.RunPrimeSieve(1000000).ToImmutableSortedSet();

            return list[10001].ToString();
        }
    }
}