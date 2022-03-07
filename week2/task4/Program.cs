// 4. Adding minutes

var time = new JupiterTime(0, 130);
PrintTime(time);
var timeIn20Minutes = time.AddMinutes(-30);
PrintTime(timeIn20Minutes);

void PrintTime(JupiterTime time)
{
    Console.WriteLine($"{time.Hour:00}:{time.Minutes:00}");
   
}
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
        return this;
    }

    public JupiterTime AddMinutes(int minutes)
    {
        Minutes = Minutes + minutes % 60;
        Hour = Hour + minutes / 60;
        
        if (Minutes < 0)
        {
            Minutes = Minutes + 60;
            Hour = Hour - 1;  
            if(Hour < 0){
                Hour = Hour + 10;
            }
        }
        
        return this;
    }
}
