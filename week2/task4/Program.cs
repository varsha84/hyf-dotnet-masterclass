// 4. Adding minutes

var time = new JupiterTime(0, 10);
PrintTime(time);
var timeIn20Minutes = time.AddMinutes(-30);
PrintTime(timeIn20Minutes);

void PrintTime(JupiterTime time)
{
    if (time.Minutes < 10)
    {
        Console.WriteLine($"{time.Hour}:0{time.Minutes}");
    }
    else
    {
        Console.WriteLine($"{time.Hour}:{time.Minutes}");
    }
}



public class JupiterTime
{
    public int Hour;
    public int Minutes;
    public JupiterTime(int hour, int minutes)
    {
        if(hour<0 || hour>23)
        {
            Console.WriteLine("Hours must be betweem 0 and 23");
            return;
        }
        Hour = hour;
        if(minutes>59)
        {
            Hour +=1;
            Minutes = minutes-60;
        }
        else
        {
            Minutes = minutes;
        }
    }
    public JupiterTime AddHours(int hour)
    {
        Hour = Hour + hour;
        if (Hour > 23)
        {
            Hour = Hour - 24;
        }
        if (Hour < 0)
        {
            Hour = Hour + 24;
        }
        return this;
    }

    public JupiterTime AddMinutes(int minutes)
    {
        Minutes = Minutes + minutes;
        if (Minutes > 59)
        {
            Minutes = Minutes - 60;
            Hour = Hour + 1;
        }
        else if (Minutes < 0)
        {
            Minutes = Minutes + 60;
            Hour = Hour - 1;  //@@TODO: if intial value of hour is zero, then we must also handle it. 
            if(Hour < 0){
                Hour = Hour + 24;
            }
        }
        
        return this;
    }
}
