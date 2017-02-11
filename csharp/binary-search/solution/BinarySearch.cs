public class BinarySearch
{
    public static int Search(int[] haystack, int needle)
    {
        if (haystack.Length == 0) return -1;

        int DivideAndConquer(int minimum, int maximum)
        {
            var middle = (minimum + maximum) / 2;

            if (haystack[middle] == needle) return middle;

            if (middle <= 0 || middle >= haystack.Length - 1) return -1;

            if (haystack[middle] > needle) return DivideAndConquer(minimum, --middle);

            return DivideAndConquer(++middle, maximum);
        }

        return DivideAndConquer(0, haystack.Length - 1);
    }
}