using SOLID_Liskov_Substitution_Principle.Models;

Square square = new();
square.SetSize(2);

Rectangle rectangle = square; // Implicit conversion from Square to Rectangle
rectangle.SetSize(3, 4); // This will not maintain the square's properties