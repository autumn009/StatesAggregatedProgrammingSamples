using System;

class A
{
    public static int Price => State.Price;
}

class B
{
    public static string Price => State.Price + "yen";
}

class State
{
    public static int Price = 100;
}

//class BadState
//{
//  public static int Price = 100;
//  public static string Price = 100;   // → Error
//}

class Program
{
    static void Main(string[] args)
    {
        if (A.Price >= 100) Console.WriteLine(B.Price);
    }
}
