namespace SOLID_Single_Responsibility_Principle.Repository;

/// <summary>
/// Manages a collection of TodoItem objects, providing methods to add, remove, update, and retrieve items.
/// </summary>
public class TodoList
{
    private List<Models.TodoItem> Items { get; set; } = [];

    public void Add(Models.TodoItem item)
    {
        if (item == null)
        {
            throw new ArgumentNullException(nameof(item), "Item cannot be null.");
        }

        if (Items.Any(i => i.Id == item.Id))
        {
            throw new ArgumentException($"An item with id {item.Id} already exists.");
        }

        Items.Add(item);
    }

    public void Remove(string id)
    {
        var item = Items.FirstOrDefault(i => i.Id == id);
        if (item != null)
        {
            Items.Remove(item);
        }
    }

    public List<Models.TodoItem> GetAll()
    {
        return Items;
    }

    public Models.TodoItem? GetById(string id)
    {
        return Items.FirstOrDefault(i => i.Id == id);
    }

    public void Update(string id, Models.TodoItem updatedItem)
    {
        if (string.IsNullOrEmpty(id) || updatedItem == null || id != updatedItem.Id)
        {
            throw new ArgumentException("Invalid id or updated item.");
        }

        var index = Items.FindIndex(i => i.Id == updatedItem.Id);
        if (index != -1)
        {
            Items[index] = updatedItem;
        }

        throw new KeyNotFoundException($"Item with id {id} not found.");
    }

    override public string ToString()
    {
        return string.Join(Environment.NewLine, Items.Select(i => i.ToString()));
    }
}