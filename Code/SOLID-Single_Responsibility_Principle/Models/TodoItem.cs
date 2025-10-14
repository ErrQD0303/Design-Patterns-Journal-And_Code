namespace SOLID_Single_Responsibility_Principle.Models;

/// <summary>
/// Represents a single to-do item
/// </summary>
public class TodoItem
{
    public string Id { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public bool IsCompleted { get; set; }

    public override string ToString()
    {
        return $"{Id}-{Title}-{Description}-{IsCompleted}";
    }
}