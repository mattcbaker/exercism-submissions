using System;

internal class Gigasecond
{
  internal static object Date(DateTime dateTime)
  {
    return dateTime.AddSeconds(Math.Pow(10, 9));
  }
}