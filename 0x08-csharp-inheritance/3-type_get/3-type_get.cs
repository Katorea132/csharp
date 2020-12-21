using System;
using System.Reflection;

/// <summary>
/// A class to hold one method
/// </summary>
class Obj
{
    /// <summary>
    /// Prints properties and methods.
    /// </summary>
    /// <param name="myObj">The object to print from.</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo propertie in type.GetProperties())
            Console.WriteLine(propertie.Name);
        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo method in type.GetMethods())
            Console.WriteLine(method.Name);
    }
}
