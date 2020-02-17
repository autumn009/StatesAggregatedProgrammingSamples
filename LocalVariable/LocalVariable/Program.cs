using System;
using System.Collections.Generic;

class ImmutableWithLocal
{
    public static int Sub(IEnumerable<int> src)
    {
        int s = 0;
        foreach (var item in src)
        {
            s <<= 1;
            s += item;
        }
        return s;
    }
}


class Program
{
    static void Main(string[] args)
    {
        int[] ar = { 1, 1, 1, 1 };
        Console.WriteLine(ImmutableWithLocal.Sub(ar));
    }
}
