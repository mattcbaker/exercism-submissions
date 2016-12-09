public class Clock
{
    private int hours;
    private int minutes;

    public Clock(int hours)
    {
        this.hours = hours;
    }

    public Clock(int hours, int minutes) : this(hours)
    {
        this.minutes = minutes;
    }

    public Clock Add(int minutes)
    {
        this.minutes += minutes;
        return this;
    }

    public object Subtract(int minutes)
    {
        this.minutes -= minutes;
        return this;
    }

    public override string ToString()
    {
        while (this.minutes > 59)
        {
            this.minutes -= 60;
            this.hours++;
        }

        while (this.hours > 23)
        {
            this.hours -= 24;
        }

        while (this.minutes < 0)
        {
            this.minutes += 60;
            this.hours--;
        }

        while (this.hours < 0)
        {
            this.hours += 24;
        }

        return $"{hours.ToString().PadLeft(2, '0')}:" + minutes.ToString().PadLeft(2, '0');
    }

    public override bool Equals(object obj)
    {
        return this.ToString() == obj.ToString();
    }
}