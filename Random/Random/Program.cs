using System;

class Program
{
    private static DateTimeOffset InGameNow = new DateTimeOffset(2025, 1, 1, 12, 0, 0, TimeSpan.FromSeconds(0));
    private static void Sub()
    {
        var r = new Random((int)InGameNow.Ticks);
        Console.WriteLine(r.Next());
        Console.WriteLine(r.Next());
        Console.WriteLine(r.Next());
    }


    static void Main(string[] args)
    {
        Sub();
    }
}
