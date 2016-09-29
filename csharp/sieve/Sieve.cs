using System.Collections.Generic;
using System.Linq;

class Sieve
{
    public static int[] Primes(int value)
    {
        var range = Enumerable.Range(2, value - 1).ToList();
        var primes = new List<int>();

        while (range.Count() > 0)
        {
            var current = range[0];
            primes.Add(current);
            range.RemoveAt(0);

            for (var i = range.Count() - 1; i >= 0; i--)
            {
                if(range[i] % current == 0)
                {
                    range.RemoveAt(i);
                }
            }
        }

        return primes.ToArray();
    }
}