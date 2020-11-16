using System;

class ItemOld
{
    private int id;
    private string name;
    public int Id { get { return id; } }
    public string Name { get { return name; } }
    public ItemOld(int id, string name)
    {
        this.id = id;
        this.name = name;
    }
}

record ItemNew1(int Id, string Name);

record ItemNew2
{
    public int Id { get; init; }
public string Name { get; init; }
public ItemNew2(int id, string name) => (Id, Name) = (id, name);
}

class Program
{
    static void Main()
    {
        var x1 = new ItemOld(1, "やくそう");
        var x2 = new ItemNew1(1, "やくそう");
        var x3 = new ItemNew1(1, "やくそう");
        Console.WriteLine($"{x1.Id},{x1.Name}");
        Console.WriteLine($"{x2.Id},{x2.Name}");
        Console.WriteLine($"{x3.Id},{x3.Name}");
    }
}
