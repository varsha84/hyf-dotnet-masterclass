//5. Better printout

var time = new JupiterTime(5, 70);
Console.WriteLine(time.ToString());

public class JupiterTime
{
    public int Hour;
    public int Minutes;

    public override string ToString()
    {
        return $"{Hour:00}:{Minutes:00}";
    }
    public JupiterTime(int hour, int minutes)
    {
        if(hour<0)
        {
            Console.WriteLine("Hours must greater than or equal to 0");
        }
        else{
            Hour = hour % 10 + minutes / 60;
            Minutes = minutes % 60;
        }
        
    }
    
}
