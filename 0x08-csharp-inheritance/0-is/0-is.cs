using System;

/// <summary>
/// A class to hold one method
/// </summary>
class Obj
{
    /// <summary>
    /// Determines with a boolean if obj is an int or not.
    /// </summary>
    /// <param name="obj">The object to evaluate.</param>
    /// <returns>A boolean.</returns>
    public static bool IsOfTypeInt(object obj) => obj is int;
}
