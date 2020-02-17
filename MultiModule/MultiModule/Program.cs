using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Class1A.Dummy();
        Class1B.Dummy();
        foreach (var assem in AppDomain.CurrentDomain.GetAssemblies())
        {
            foreach (var type in assem.GetTypes())
            {
                var att = type.GetCustomAttribute(typeof(MyFlagsAttribute));
                if (att == null) continue;
                if (type.GetMethod("Save") == null) continue;
                type.InvokeMember("Save", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
            }
        }
    }
}
