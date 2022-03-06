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

        foreach (var Timer in Timers)
        {
            Console.WriteLine($"{Timer.Hour} : {Timer.Minutes}");
        }

    }
    public void InformRemainingTimers()
    {
        if(RemainingTimers.Count ==0){
            Console.WriteLine("RemainingTimers No timers added yet.");
            return;
        }
        foreach (var Timer in RemainingTimers)
        {
            Console.WriteLine($"Remaining Timers {Timer.Hour} : {Timer.Minutes}");
        }

    }
    public void Check(JupiterTime time){
        foreach(var Timer in Timers){
            if(time.Hour < Timer.Hour )
            {
               RemainingTimers.Add(Timer);
            }
            else if( (time.Hour == Timer.Hour) && (time.Minutes< Timer.Minutes) ){
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

