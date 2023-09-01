using System;

namespace Number_Sequence__3_;

public class Solution
{
    static void Main()
    {
        string Line1 = Console.ReadLine();
        int Line2 = int.Parse(Console.ReadLine());

        int Different = int.Parse(Line1.Split(' ')[1]) - int.Parse(Line1.Split(' ')[0]);
        int Current = int.Parse(Line1.Split(' ')[2]);
        Console.Write(Line1 + " ");
        for (int x = 0; x < Line2; x++)
        {
            Current += Different;
            Console.Write(Current);
            if (x == Line2)
            {
                break;
            }
            Console.Write(" ");
        }
    }
}
