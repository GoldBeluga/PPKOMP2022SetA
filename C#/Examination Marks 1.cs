using System;
using System.Collections.Generic;
using System.Linq;


namespace Examination_Marks_1;

public class Solution
{
    static void Main()
    {
        var Marks = new Dictionary<int, double>()
        {
            { 0, 0 },
            { 1, 0 },
            { 2, 0 },
            { 3, 0 },
        };
        for (int x = 0; x < 4; x++)
        {
            string Value = Console.ReadLine();
            double Molecular = double.Parse(Value.Split('/')[0]) ;
            double Denominator = double.Parse(Value.Split('/')[1]);

            Marks[x] = Molecular / Denominator * 100d;
        }
        var MarksList = Marks.Values.ToList();
        MarksList.Sort();
        int TargetIndex = Marks.First(x => x.Value == MarksList[3]).Key;
        switch (TargetIndex)
        {
            case 0:
                Console.WriteLine("Bahasa Melayu");
                break;
            case 1:
                Console.WriteLine("Bahasa Inggeris");
                break;
            case 2:
                Console.WriteLine("Sains");
                break;
            case 3:
                Console.WriteLine("Matematik");
                break;
        }
    }
}
