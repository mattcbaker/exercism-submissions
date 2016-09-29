using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfMultiplesNamespace
{
    class SumOfMultiples
    {
        List<int> _GivenNumbers;
        public SumOfMultiples()
            :this(new List<int>() { 3, 5 })
        {

        }

        public SumOfMultiples(List<int> factors)
        {
            _GivenNumbers = factors;
        }

        public int To(int bound)
        {
            int sum = 0;

            for (var i = bound - 1; i >= 0; i--)
            {
                if (i.IsDivisibleBy(_GivenNumbers))
                {
                    sum += i;
                }
            }

            return sum;
        }
    }

    static class IntExtensions
    {
        public static bool IsDivisibleBy(this int root, List<int> factors)
        {
            var divisible = false;

            foreach (int factor in factors)
            {
                if (root % factor == 0)
                {
                    divisible = true;
                    break;
                }
            }

            return divisible;
        }
    }
}