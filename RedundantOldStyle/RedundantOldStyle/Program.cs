using System;

class A
{
    public static string Price = "100yen";
}

class B
{
    public static int Price = 100;
}


class Program
{
    static void Main(string[] args)
    {
        if (B.Price >= 100) Console.WriteLine(A.Price);
    }
}
