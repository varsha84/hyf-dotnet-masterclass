// 6. Let's get things done

var signaler = new Signaler();


signaler.AddTime(new JupiterTime(1, 20));
signaler.AddTime(new JupiterTime(2, 20));
signaler.AddTime(new JupiterTime(3, 20));
signaler.Inform();


public class Signaler
{
    List<JupiterTime> Timers = new List<JupiterTime>();


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

        foreach (var Timer in Timers)
        {
            Console.WriteLine($"{Timer.Hour} : {Timer.Minutes}");
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
        if (hour < 0 || hour > 23)
        {
            Console.WriteLine("Hours must be betweem 0 and 23");
        }
        Hour = hour;
        if (minutes > 59)
        {
            minutes = minutes - 60;
            Hour += 1;
        }
        else
        {
            Minutes = minutes;
        }
    }

}
