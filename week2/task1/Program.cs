// 1. A simple tracker

var time = new JupiterTime();
time.Hour = 8;
time.Minutes = 9;

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hour:00}:{time.Minutes:00}"); 
}

PrintTime(time);
public class JupiterTime
{
    public int Hour;
    public int Minutes;
}
