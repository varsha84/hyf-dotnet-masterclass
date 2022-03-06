//5. Better printout

var time = new JupiterTime(5, 10);
Console.WriteLine(time.ToString());

public class JupiterTime
{
    public int Hour;
    public int Minutes;

    public override string ToString()
    {
        return Hour + ":" + Minutes;
    }
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
    
}
