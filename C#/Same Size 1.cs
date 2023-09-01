using System;

namespace Same_Size_1;

public class Solution
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine() ?? "");
        int n = int.Parse(Console.ReadLine() ?? "");
        m -= m % n;
        Console.WriteLine(m / n);
    }
}
