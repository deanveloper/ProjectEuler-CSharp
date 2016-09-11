namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Figure out the longest collatz sequence.
    /// </summary>
    public class Problem14 : IProblem
    {
        public string Solve()
        {
            uint largest = 0;
            var largestTerms = 0;
            for (uint start = 1; start < 1000000; start++)
            {
                var terms = 0;
                var n = start;
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    terms++;
                }
                if (terms <= largestTerms) continue;
                largest = start;
                largestTerms = terms;
            }

            return largest.ToString();
        }
    }
}