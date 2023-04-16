using System;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.Problems20
{
    /// <summary>
    /// Gets the sum of the digits of 100 factorial
    /// </summary>
    public class Problem20 : IProblem
    {
        public string Solve()
        {
            var fac = Factorial(100, 100);

            var sum = fac.ToString().Sum(letter => int.Parse(letter.ToString()));

            return sum.ToString();
        }

        BigInteger Factorial(uint num, BigInteger fac)
        {
            while (true)
            {
                Console.WriteLine($"{num} {fac}");
                num = num - 1;
                if (num == 0)
                {
                    return fac;
                }
                fac = fac * num;
            }
        }
    }
}