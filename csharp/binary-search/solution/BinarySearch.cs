using System;
using System.Linq;

public class BinarySearch
{
    public static int Search(int[] haystack, int needle)
    {
        int DivideAndConquer(int[] currentHaystack, int offset)
        {
            if (currentHaystack.Length == 0) return -1;
            if (currentHaystack.Length == 1 && currentHaystack[0] != needle) return -1;

            var middle = (int)Math.Floor(currentHaystack.Length / 2.0);

            if (currentHaystack[middle] == needle) return middle + offset;

            if (currentHaystack[middle] > needle)
            {
                return DivideAndConquer(currentHaystack.Take(middle).ToArray(), offset);
            }

            return DivideAndConquer(currentHaystack.Skip(middle).ToArray(), offset + middle);
        }

        return DivideAndConquer(haystack, 0);
    }
}