using System;

class State
{
    private static int min, max, val;
    private static void checkIntegiriy()
    {
        if (val < min || val > max) throw new ArgumentException("State Integrity Fail");
    }

    public static int Min
    {
        get => min; set
        {
            min = value;
            checkIntegiriy();
        }
    }

    public static int Max
    {
        get => max; set
        {
            max = value;
            checkIntegiriy();
        }
    }

    public static int Val
    {
        get => val; set
        {
            val = value;
            checkIntegiriy();
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        State.Min = 0;
        State.Max = 100;
        State.Val = 50;
        State.Max = 25;
        Console.WriteLine($"最小値{State.Min} 最大値{State.Max} 現在値{State.Val}");
    }
}
