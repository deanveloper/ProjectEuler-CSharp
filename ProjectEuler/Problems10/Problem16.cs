using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Find the sum of the digits of 2^1000.
    /// </summary>
    public class Problem16 : IProblem
    {
        public string Solve()
        {
            var num = new BigInteger(1);
            for (var i = 0; i < 1000; i++)
            {
                num *= 2;
            }

            var sum = num.ToString().Sum(c => int.Parse(c.ToString()));

            return sum.ToString();
        }
    }
}