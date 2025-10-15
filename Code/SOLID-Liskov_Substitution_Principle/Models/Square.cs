namespace SOLID_Liskov_Substitution_Principle.Models;

public class Square
{
    private Rectangle Rectangle { get; init; }

    public Square()
    {
        Rectangle = new Rectangle();
    }

    public Square(int size)
    {
        Rectangle = new Rectangle(size, size);
    }

    public static implicit operator Rectangle(Square square) => square.Rectangle;

    public int Area
    {
        get
        {
            if (Rectangle.Width != Rectangle.Height)
                throw new InvalidOperationException("Square properties have been violated.");

            return Rectangle.Area;
        }
    }

    public void SetSize(int size)
    {
        if (size < 0)
            throw new ArgumentException("Size must be non-negative.");

        Rectangle.SetSize(size, size);
    }
}