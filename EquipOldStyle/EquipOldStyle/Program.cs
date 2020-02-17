using System;
using System.IO;

public class Util
{
    public static void Save(Person p)
    {
        using(var f = File.CreateText("savedata.txt"))
        {
            f.WriteLine(p.Name);
            f.WriteLine(p.Equip);
        }
    }
}

public class Person
{
    public string Name { get; set; } = "ヒトミ";
    public string Equip { get; set; } = "レオタード";
}

class Program
{
    static void Main(string[] args)
    {
        var 主人公 = new Person();
        Console.WriteLine($"{主人公.Name}は{主人公.Equip}を着ています。");
        Util.Save(主人公);
    }
}
