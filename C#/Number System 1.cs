// Question from https://www.hackerrank.com/contests/2022ppkomp-a-en/challenges/en-sistem-nombor-1

using System;
using System.Collections.Generic;
using System.Linq;

namespace Number_System_1;

public class Solution
{
    static void Main()
    {
        Console.WriteLine((Console.ReadLine() ?? "").ToCharArray().ToList().TrueForAll(x => x != '8' && x != '9') ? "sah" : "tidak sah" );
    }
}
