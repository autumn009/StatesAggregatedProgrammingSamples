using System;

class Mutable
{
    private string name;
    public string Name { get; set; } = "アイ";
}

class Immutable
{
    public string Name { get => "ルイ"; }
}



class Program
{
    static void Main(string[] args)
    {
        var ai = new Mutable();
        var rui = new Immutable();
        ai.Name = "ルイ";
        //rui.Name = "アイ"; 実行できない
        Console.WriteLine(ai.Name);
        Console.WriteLine(rui.Name);
    }
}
