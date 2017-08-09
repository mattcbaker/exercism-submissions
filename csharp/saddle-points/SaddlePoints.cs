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

  public IEnumerable<Tuple<int, int>> Calculate() =>
    EnumerateMatrix()
      .Where(x => IsSaddlePoint(x.Item1, x.Item2))
      .Select(x => x);

  bool IsSaddlePoint(int row, int column) =>
    IsGreaterThanOrEqualToEveryValueInRow(matrix[row, column], row)
    && IsLessThanOrEqualToEveryValueInColumn(matrix[row, column], column);

  bool IsGreaterThanOrEqualToEveryValueInRow(int value, int row) =>
    Enumerable
      .Range(0, matrix.GetLength(1))
      .All(x => value >= matrix[row, x]);

  bool IsLessThanOrEqualToEveryValueInColumn(int value, int column) =>
    Enumerable
      .Range(0, matrix.GetLength(0))
      .All(x => value <= matrix[x, column]);

  IEnumerable<Tuple<int, int>> EnumerateMatrix()
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
      for (int j = 0; j < matrix.GetLength(1); j++)
        yield return Tuple.Create(i, j);
  }
}