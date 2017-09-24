using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if(number <= 0) throw new ArgumentException();

        return RecursionHelper(number, 0);
    }

    static int RecursionHelper(int number, int total)
    {
        if (number == 1) return total;

        if (number % 2 == 0)
        {
            return RecursionHelper(number / 2, ++total);
        }

        return RecursionHelper(number*3+1, ++total);
    }
}