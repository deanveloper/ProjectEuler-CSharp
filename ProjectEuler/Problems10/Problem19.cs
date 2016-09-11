using System;
using Humanizer;

namespace ProjectEuler.Problems10
{
    /// <summary>
    /// Find the number of sundays that fell on the first of a month in the 20th century.
    /// </summary>
    public class Problem19 : IProblem
    {
        public string Solve()
        {
            var sundays = 0;
            var sevenDays = TimeSpan.FromDays(7);
            var day = new DateTime(1901, 1, 1);
            var stopAt = new DateTime(2000, 12, 31);

            while (day.DayOfWeek != DayOfWeek.Sunday)
            {
                day += TimeSpan.FromDays(1);
            }

            while (day <= stopAt)
            {
                if (day.Day == 1 && day.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundays++;
                }
                day += sevenDays;
            }

            return sundays.ToString();
        }
    }
}