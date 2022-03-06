//2. Adding constructor
var time = new JupiterTime(4, 9);


void PrintTime(JupiterTime time)
{
    if(time.Minutes < 10){
        Console.WriteLine($"{time.Hour}:0{time.Minutes}");
    }
    else{
        Console.WriteLine($"{time.Hour}:{time.Minutes}");
    } 
}

PrintTime(time);
public class JupiterTime
{
    public int Hour;
    public int Minutes;

    public JupiterTime(int hour, int minutes)
    {
        Hour = hour;
        if(minutes>59){
            Hour +=1;
            Minutes = minutes-60;
        }
        else{
            Minutes = minutes;
        }
        
    }
}
