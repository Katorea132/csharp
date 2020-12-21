using System;

/// <summary>
/// A class to hold one method
/// </summary>
class Obj
{
    /// <summary>
    /// Determines if the object is or not an array or derived from arrays.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>A boolean.</returns>
    public static bool IsInstanceOfArray(object obj) => obj is Array;
}
