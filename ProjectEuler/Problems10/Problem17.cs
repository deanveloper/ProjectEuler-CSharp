using Humanizer;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Sum of the length of spelled out numbers from 1-1000.
    /// </summary>
    /// <remarks>
    /// I knew of a previous library called Humanize which can do this for us.
    /// </remarks>
    public class Problem17 : IProblem
    {
        public string Solve()
        {
            var sum = 0L;
            for (var i = 1; i <= 1000; i++)
            {
                sum += i.ToWords().Replace(" ", "").Replace("-", "").Length;
            }

            return sum.ToString();
        }
    }
}