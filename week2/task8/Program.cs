// 8. We flew over to Titan


var time1 = new TitanTime(1000, 40);
var time2 = new TitanTime(30, 70);
var time3 = new TitanTime(31, 10);

Console.WriteLine(time1.ToString());
Console.WriteLine(time2.ToString());
Console.WriteLine(time3.ToString());
public class TitanTime
{
    public int Hour;
    public int Minutes;
    public TitanTime(int hour, int minutes)
    {
        if(hour<0)
        {
            Console.WriteLine("Hours must greater than or equal to 0");
            
        }
        else{
            Hour = hour % 900 + minutes / 60;
            Minutes = minutes % 60;
        }
        
    }

    public override string ToString()
    {
        return $"{Hour:000}:{Minutes:00}";
    }

}
