// 3. Adding time
var time = new JupiterTime(23, 70);
PrintTime(time);

var timeIn1Hour = time.AddHours(3);
PrintTime(timeIn1Hour);

// printing time format

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hour:00}:{time.Minutes:00}");
}

// Class JupiterTime
public class JupiterTime
{
    public int Hour;
    public int Minutes;

    //class constructer check hour and minutes
    public JupiterTime(int hour, int minutes)
    {
       Hour = hour % 10 + minutes / 60;
        Minutes = minutes % 60;

    }
    // class method defination
    public JupiterTime AddHours(int hour)
    {
        Hour = Hour + hour;
        if (Hour > 9)
        {
            Hour = Hour % 10;
        }
        if (Hour < 0)
        {
            Hour = Hour + 10;
        }
        return new JupiterTime(Hour, Minutes);
    }
}

