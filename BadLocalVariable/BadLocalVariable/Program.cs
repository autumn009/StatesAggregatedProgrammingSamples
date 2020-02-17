using System;

class BadCase
{
    public Action Sub()
    {
        int count=0;
        return () =>
        {
            Console.WriteLine(count++);
        };
    }
}


class Program
{
    static void Main(string[] args)
    {
        var a = new BadCase();
        var act = a.Sub();
        act();
        act();
        act();
    }
}
