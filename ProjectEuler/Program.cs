using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectEuler.Problems10;
using ProjectEuler.Problems20;

namespace ProjectEuler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var problem = new Problem20();
            Console.WriteLine(problem.Solve());
        }
    }

    public interface IProblem
    {
        string Solve();
    }

    public static class ProjectEuler
    {
        public static readonly Random Rand = new Random();

        public static bool IsPrime(this long num)
        {
            return RunPrimeSieve(num).Contains(num);
        }

        public static string Flip(this string s)
        {
            var charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static uint DivideEvenly(this uint source, uint num)
        {
            if (num == 0)
            {
                return 0;
            }
            var closestDivisor = (uint) (source / (double) num);
            return source == closestDivisor * num ? closestDivisor : 0;
        }

        public static long PerfectSqrt(long num)
        {
            var closestRoot = (long) Math.Sqrt(num);
            return num == closestRoot * closestRoot ? closestRoot : -1;
        }

        /// <summary>
        /// Sieves out prime numbers between 2 and the max.
        /// </summary>
        /// <param name="max">The largest prime number to look for</param>
        /// <returns>An enumerable that contains the prime numbers between 2 and the max</returns>
        public static HashSet<long> RunPrimeSieve(long max)
        {
            // A dictionary to store whether each number has been sieved or not.
            // True means that it has been sieved, meaning it has been marked as non-prime
            var sieve = new Dictionary<long, bool>();

            var primes = new HashSet<long>();

            // Populate the sieve with all values from 2 to max.
            for (long x = 2; x <= max; x++)
            {
                sieve[x] = false;
            }

            // Sieve through with all possible numbers.
            for (long i = 2; i <= max; i++)
            {
                // Ignore the number if it was a multiple of a previous number.
                // Otherwise mark it as prime and scanned and continue.
                if (sieve[i]) continue;
                primes.Add(i);
                sieve[i] = true;

                // Mark all multiples of this number as non-prime.
                for (long j = i * 2; j <= max; j += i)
                {
                    sieve[j] = true;
                }
            }

            return primes;
        }
    }
}


