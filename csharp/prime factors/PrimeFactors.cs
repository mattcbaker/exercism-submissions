using System;
using System.Collections.Generic;

internal class PrimeFactors
{
  internal static int[] For(long natural)
  {
    var factors = new List<int>();

    var divisor = 2;

    while(natural > 1)
    {
      while(natural % divisor == 0)
      {
        factors.Add(divisor);
        natural /= divisor;
      }

      divisor++;
    }

    return factors.ToArray();
  }
}