namespace SOLID_Liskov_Substitution_Principle.Models;

public class Rectangle
{
    public int Width { get; protected set; }
    public int Height { get; protected set; }

    public Rectangle()
    { }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int Area => Width * Height;

    public void SetSize(int width, int height)
    {
        if (width < 0 || height < 0)
            throw new ArgumentException("Width and Height must be non-negative.");

        Width = width;
        Height = height;
    }
}