// 3. Adding time

var time = new JupiterTime(2, 20);
PrintTime(time);

var timeIn1Hour = time.AddHours(1);
PrintTime(timeIn1Hour);

// printing time format

void PrintTime(JupiterTime time)
{
    if(time.Minutes < 10){
        Console.WriteLine($"{time.Hour}:0{time.Minutes}");
    }
    else{
        Console.WriteLine($"{time.Hour}:{time.Minutes}");
    } 
}

// Class JupiterTime
public class JupiterTime
{
    public int Hour;
    public int Minutes;

    //class constructer check hour and minutes
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
    // class method defination
    public JupiterTime AddHours(int hour){
        Hour = Hour + hour;
        if(Hour>23){
            Hour = Hour - 24;
        }
        if(Hour<0)
        {
            Hour = Hour + 24;
        }
        return this;
    }

    
}

