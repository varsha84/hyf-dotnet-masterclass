
//10. Extra comment - generics (bonus - information purpose only)

var time = new JupiterTime(25, 30);
Console.WriteLine(time.ToString());
var jtime = new JupiterTime(25, 30).AddHours(1);
var ttime = new TitanTime(25, 30).AddHours(1);

Console.WriteLine(jtime.ToString());
Console.WriteLine(ttime.ToString());

public abstract class AlienTime
{
    public int Hour;
    public int Minutes;
    private int _hoursInDay;
    public AlienTime AddHours(int hour)
    {
        Hour = Hour + hour;
        if (Hour >= _hoursInDay)
        {
            Hour = Hour % _hoursInDay;
        }
        if (Hour < 0)
        {
            Hour = Hour + _hoursInDay;
        }
        return this;
    }
    public AlienTime(int hour, int minutes, int hoursInDay)
    {
        _hoursInDay = hoursInDay;

        Hour = hour % hoursInDay + minutes / 60;
        Minutes = minutes % 60;

    }

    public override string ToString()
    {
        return $"{Hour:000}:{Minutes:00}";
    }


}

public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }

    public override string ToString()
    {
        return $"{Hour:00}:{Minutes:00}";
    }
}

public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }


}

public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }

}
