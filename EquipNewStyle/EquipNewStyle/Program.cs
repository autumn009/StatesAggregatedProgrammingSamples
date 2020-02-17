using System;
using System.IO;
using System.Collections.Generic;

public class Util
{
    public static Dictionary<string, string> Flags = new Dictionary<string, string>();
    public static void Save(Person p)
    {
        using (var f = File.CreateText("savedata.txt"))
        {
            foreach (var item in Flags)
            {
                f.WriteLine(item.Key);
                f.WriteLine(item.Value);
            }
        }
    }
}

public class Person
{
    public string Id = "UniqIdNumber";

    public string Name {
        get { return Util.Flags[Id + "Name"]; }
        set { Util.Flags[Id + "Name"] = value; }
    }
    public string Equip {
        get { return Util.Flags[Id + "Equip"]; }
        set { Util.Flags[Id + "Equip"] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var 主人公 = new Person() { Name = "ヒトミ", Equip = "レオタード" };
        Console.WriteLine($"{主人公.Name}は{主人公.Equip}を着ています。");
        Util.Save(主人公);
    }
}
