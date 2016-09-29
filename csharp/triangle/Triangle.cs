using System;
using System.Collections.Generic;
using System.Linq;

internal enum TriangleKind
{
  Equilateral,
  Isosceles,
  Scalene
}

class TriangleException : Exception { }

class Triangle
{
  private IList<decimal> sides;

  public Triangle(decimal one, decimal two, decimal three)
  {
    sides = new List<decimal>() { one, two, three };
  }

  public static TriangleKind Kind(decimal one, decimal two, decimal three)
  {
    var triangle = new Triangle(one, two, three);

    ThrowIfTriangleViolatesEqualityRule(triangle);

    if (triangle.AreAllSidesEqual())
    {
      return TriangleKind.Equilateral;
    }
    else if (triangle.AreTwoSidesEqual())
    {
      return TriangleKind.Isosceles;
    }

    return TriangleKind.Scalene;
  }

  private static void ThrowIfTriangleViolatesEqualityRule(Triangle triangle)
  {
    if (triangle.ViolatesEqualityRule())
    {
      throw new TriangleException();
    }
  }

  private bool AreAllSidesEqual()
  {
    return sides.All(s => s == sides.First());
  }

  private bool AreTwoSidesEqual()
  {
    return sides.Any(side => sides.Where(s => s == side).Count() > 1);
  }

  private bool ViolatesEqualityRule()
  {
    var first = sides.First();
    var second = sides.ElementAt(1);
    var third = sides.Last();

    return (first + second <= third) || (second + third <= first) || (third + first <= second);
  }
}