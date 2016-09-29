using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Hamming
{

    internal static int Compute(string p1, string p2)
    {
        if (p1.Length != p2.Length)
        {
            throw new ArgumentException();
        }

        return CalculateHammingDistance(p1, p2);
    }

    private static int CalculateHammingDistance(string p1, string p2)
    {
        int hammingDistance = 0;

        if (p1 != p2)
        {
            for (var i = 0; i < p1.Length; i++)
            {
                if (p1[i] != p2[i])
                {
                    hammingDistance++;
                }
            }
        }

        return hammingDistance;
    }
}
