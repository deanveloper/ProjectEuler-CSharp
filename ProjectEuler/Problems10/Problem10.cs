using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using static ProjectEuler.ProjectEuler;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Find the sum of all prime numbers below 2,000,000.
    /// </summary>
    public class Problem10 : IProblem
    {
        public string Solve()
        {
            var sum = new BigInteger(0);

            var nums = RunPrimeSieve(2000000);

            foreach (var num in nums)
            {
                sum += num;
            }

            return sum.ToString();
        }
    }
}