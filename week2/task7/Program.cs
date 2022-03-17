// 7. We fell asleep! What should we do now?

var signaler = new Signaler();


signaler.AddTime(new JupiterTime(4, 20));
signaler.AddTime(new JupiterTime(2, 20));
signaler.AddTime(new JupiterTime(3, 20));
signaler.Check(new JupiterTime(2, 40));
signaler.InformRemainingTimers();
public class Signaler
{
    List<JupiterTime> Timers = new List<JupiterTime>();
    List<JupiterTime> RemainingTimers = new List<JupiterTime>();


    public void AddTime(JupiterTime time)
    {
        Timers.Add(time);
    }
    public void Inform()
    {
        if (Timers.Count == 0)
        {
            Console.WriteLine("No timers added yet.");
            return;
        }

        foreach (var timer in Timers)
        {

            Console.WriteLine($"{Timer.Hour:00}:{Timer.Minutes:00}");
        }
    }
    public void InformRemainingTimers()
    {
        if (RemainingTimers.Count == 0)
        {
            Console.WriteLine("RemainingTimers No timers added yet.");
            return;
        }
        foreach (var timer in RemainingTimers)
        {
            Console.WriteLine($"{Timer.Hour:00}:{Timer.Minutes:00}");
        }
    }
    public void Check(JupiterTime time)
    {
        foreach (var timer in Timers)
        {
            if (time.Hour < Timer.Hour)
            {
                RemainingTimers.Add(Timer);
            }
            else if ((time.Hour == Timer.Hour) && (time.Minutes < Timer.Minutes))
            {
                RemainingTimers.Add(Timer);
            }
        }
    }

}

//class defination JupiterTime
public class JupiterTime
{
    public int Hour;
    public int Minutes;

    public JupiterTime(int hour, int minutes)
    {
        if (hour < 0)
        {
            Console.WriteLine("Hours must greater than or equal to 0");
        }
        else
        {
            Hour = hour % 10 + minutes / 60;
            Minutes = minutes % 60;
        }
    }

}

