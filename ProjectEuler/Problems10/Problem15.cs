using System;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Find the number of ways to traverse a 20x20 grid.
    /// </summary>
    public class Problem15 : IProblem
    {
        public string Solve()
        {
            ulong count = 0;
            TraversablePaths(20, 0, 0, ref count);
            return count.ToString();
        }

        public void TraversablePaths(int gridSize, int x, int y, ref ulong count)
        {
            if (x != gridSize)
            {
                TraversablePaths(gridSize, x + 1, y, ref count);
            }

            if (y != gridSize)
            {
                TraversablePaths(gridSize, x, y + 1, ref count);
            }

            if (x == gridSize && y == gridSize)
            {
                count++;
            }
        }
    }
}