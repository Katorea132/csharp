using System;

/// <summary>
/// Shappero0onies
/// </summary>
class Shape
{
    /// <summary>
    /// Macarronies
    /// </summary>
    /// <returns></returns>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectanglero0onies
/// </summary>
class Rectangle : Shape
{
    /// <summary>
    /// width of the rectangle.
    /// </summary>
    int width;
    /// <summary>
    /// height of the rectangle.
    /// </summary>
    int height;

    /// <summary>
    /// Property to get and set the width.
    /// </summary>
    /// <value>width to set, should be 0 or higher.</value>
    public int Width
    {
        get => width;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            width = value;
        }
    }

    /// <summary>
    /// Property to get and set height.
    /// </summary>
    /// <value>height to set, should be 0 or higher.</value>
    public int Height
    {
        get => height;
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
}
