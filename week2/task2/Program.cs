//2. Adding constructor
var time = new JupiterTime(14, 70);


void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hour:00}:{time.Minutes:00}");
}

PrintTime(time);

public class JupiterTime
{
    public int Hour;
    public int Minutes;

    public JupiterTime(int hour, int minutes)
    {
        Hour = hour % 10 + minutes / 60;
        Minutes = minutes % 60;
    }
}
