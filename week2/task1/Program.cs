// 1. A simple tracker

var time = new JupiterTime();
time.Hour = 8;
time.Minutes = 9;

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
}



