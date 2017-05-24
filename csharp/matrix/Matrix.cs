using System;
using System.Linq;

public class Matrix
{
    readonly string input;

    public Matrix(string input)
    {
        this.input = input;
    }

    public int Rows => input.Split('\n').Length;

    public int Cols => input.Split('\n').First().Split(' ').Length;

    public int[] Row(int row)
    {
        return input
            .Split('\n')[row]
            .Split(' ')
            .Select(c => int.Parse(c.ToString()))
            .ToArray();
    }

    public int[] Col(int col)
    {
        return input
            .Split('\n')
            .Select(row => int.Parse(row.Split(' ')[col]))
            .ToArray();
    }
}