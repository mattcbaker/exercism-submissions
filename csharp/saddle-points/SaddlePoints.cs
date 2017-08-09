using System;
using System.Collections.Generic;
using System.Linq;

public class SaddlePoints
{
  readonly int[,] matrix;

  public SaddlePoints(int[,] matrix)
  {
    this.matrix = matrix;
  }

  public IEnumerable<Tuple<int, int>> Calculate()
  {
    var saddlePoints = new List<Tuple<int, int>>();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (IsSaddlePoint(i, j))
        {
          saddlePoints.Add(Tuple.Create(i, j));
        }
      }
    }

    return saddlePoints.ToArray();
  }

  bool IsSaddlePoint(int row, int column)
  {
    return
      GreaterThanOrEqualToEveryItemInRow(matrix[row, column], row)
      && LessThanOrEqualToEveryItemInColumn(matrix[row, column], column);
  }

  bool GreaterThanOrEqualToEveryItemInRow(int value, int row)
  {
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
      if (value < matrix[row, i]) return false;
    }

    return true;
  }

  bool LessThanOrEqualToEveryItemInColumn(int value, int column)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      if (value > matrix[i, column]) return false;
    }

    return true;
  }
}