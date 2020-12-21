using System;

/// <summary>
/// A class to hold one method
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if a class is a subclass of a class.
    /// </summary>
    /// <param name="derivedType">The type to check.</param>
    /// <param name="baseType">The type to check against.</param>
    /// <returns>A boolean.</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType) => derivedType.IsSubclassOf(baseType);
}
