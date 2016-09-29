using System;
using System.Linq;

public class Grains
{
    public static double Square(int number) => Math.Pow(2, --number);

    public static double Total()
    {
        double total = 0;

        for (var i = 1; i < 65; i++)
        {
            total += Square(i);
        }

        return total;
    }
}