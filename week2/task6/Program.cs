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
            Console.WriteLine($"{Timer.Hour:00}:{Timer.Minutes:00}");
            
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
        if(hour<0)
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
