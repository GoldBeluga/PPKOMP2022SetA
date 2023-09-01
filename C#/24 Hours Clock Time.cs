using System;

namespace _24_Hours_Clock_Time;

public class Solution
{
    static void Main()
    {
        string Line1 = Console.ReadLine() ?? "";
        DateTime Date = new(2023, 12, 12, int.Parse(Line1.Split(':')[0]), int.Parse(Line1.Split(':')[1]), 0);
        int Min = int.Parse(Console.ReadLine());
        Date = Date.AddMinutes(Min);
        Console.WriteLine((Date.Hour < 10 ? "0" + Date.Hour : Date.Hour) + ":" + (Date.Minute < 10 ? "0" + Date.Minute : Date.Minute));
    }
}
