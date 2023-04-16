using System;

namespace ProjectEuler.Problems0
{
    /// <summary>
    /// Find the sum of squares and the square of the sum of all numbers 1-100.
    /// </summary>
    public class Problem6 : IProblem
    {
        public string Solve()
        {
            long sumOfSquares = 0;
            long squareOfSum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }
            squareOfSum *= squareOfSum;

            return (sumOfSquares - squareOfSum).ToString();
        }
    }
}