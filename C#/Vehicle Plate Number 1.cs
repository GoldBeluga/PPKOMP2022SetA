using System;
using System.Linq;

namespace Vehicle_Plate_Number_1;

public class Solution
{
    static void Main()
    {
        string Line1 = Console.ReadLine();
        int Sum = Line1.Where(char.IsNumber).ToList().Sum(x => int.Parse(x.ToString()));
        Console.WriteLine(Sum);
    }
}
