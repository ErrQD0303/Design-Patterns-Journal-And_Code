namespace SOLID_Single_Responsibility_Principle.Repository;

/// <summary>
/// Handles persistence operations for TodoList, such as saving to and loading from a file.
/// </summary>
public class PersistenceManager
{
    public static void SaveToFile(TodoList todoList, string fileName, bool overwrite = false)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(fileName) ?? string.Empty);

        if (overwrite || !File.Exists(fileName))
        {
            File.WriteAllText(fileName, todoList.ToString());
            return;
        }

        throw new IOException("File already exists. Set overwrite to true to overwrite.");

    }

    public static TodoList LoadFromFile(string fileName)
    {
        if (!File.Exists(fileName))
        {
            throw new FileNotFoundException("File not found.", fileName);
        }

        string data = File.ReadAllText(fileName);

        TodoList fileTodoList = new();
        foreach (var line in data.Split(Environment.NewLine))
        {
            var parts = line.Split('-');
            if (parts.Length != 4) continue;

            fileTodoList.Add(new Models.TodoItem
            {
                Id = parts[0],
                Title = parts[1],
                Description = parts[2],
                IsCompleted = bool.Parse(parts[3])
            });
        }

        return fileTodoList;
    }
}