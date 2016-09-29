using System;
using System.Linq;

public enum Schedule
{
  First,
  Teenth,
  Second,
  Third,
  Fourth,
  Last
}

public class Meetup
{
  readonly int Month;
  readonly int Year;

  public Meetup(int month, int year)
  {
    Month = month;
    Year = year;
  }

  internal DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
  {
    DateTime[] days = GetPotentialDays(dayOfWeek);

    var filter = ScheduleToFilterMapper.MapToFilter(schedule);

    return filter(days);
  }

  private DateTime[] GetPotentialDays(DayOfWeek dayOfWeek)
  {
    return Enumerable.Range(1, DateTime.DaysInMonth(Year, Month))
      .Select(day => new DateTime(Year, Month, day))
      .Where(day => day.DayOfWeek == dayOfWeek)
      .ToArray();
  }
}

static class ScheduleToFilterMapper
{
  public static Func<DateTime[], DateTime> MapToFilter(Schedule schedule)
  {
    Func<DateTime[], DateTime> filter = (filtered) => { throw new NotImplementedException("Filter for schedule not found."); };

    switch (schedule)
    {
      case Schedule.First:
        filter = Filters.MakeNthFilter(1);
        break;
      case Schedule.Teenth:
        filter = Filters.Teenth;
        break;
      case Schedule.Second:
        filter = Filters.MakeNthFilter(2);
        break;
      case Schedule.Third:
        filter = Filters.MakeNthFilter(3);
        break;
      case Schedule.Fourth:
        filter = Filters.MakeNthFilter(4);
        break;
      case Schedule.Last:
        filter = Filters.Last;
        break;
    }

    return filter;
  }
}

static class Filters
{
  public static Func<DateTime[], DateTime> Last = (filtered) => { return filtered.Last(); };
  public static Func<DateTime[], DateTime> Teenth = (filtered) => { return filtered.First(day => day.Day >= 13); };

  public static Func<DateTime[], DateTime> MakeNthFilter(int nth)
  {
    Func<DateTime[], DateTime> Nth = (filtered) => { return filtered.Skip(nth - 1).First(); };

    return Nth;
  }

}