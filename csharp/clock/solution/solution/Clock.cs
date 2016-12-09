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

    public Clock Add(int minutes) => new Clock(this.hours, this.minutes + minutes);

    public object Subtract(int minutes) => new Clock(this.hours, this.minutes - minutes);

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

        return $"{hours:d2}:{minutes:d2}";
    }

    public override bool Equals(object obj) => this.ToString() == obj?.ToString();
}