using SOLID_Single_Responsibility_Principle.Helpers;
using SOLID_Single_Responsibility_Principle.Repository;

string fileName = TodoListHelper.GetTodoListFilePath();

TodoList todoList;

if (File.Exists(fileName))
{
    todoList = PersistenceManager.LoadFromFile(fileName);
    Console.WriteLine("Loaded Todo List from file:");
    Console.WriteLine(todoList);

    try
    {
        todoList.Add(new SOLID_Single_Responsibility_Principle.Models.TodoItem
        {
            Id = "3",
            Title = "Read a Book",
            Description = "Finish reading 'Clean Code' by Robert C. Martin.",
            IsCompleted = false
        });

        Console.WriteLine("\nUpdated Todo List:");
        Console.WriteLine(todoList);
    }
    catch (Exception ex)
    {
        // This should catch exceptions like duplicate IDs
        Console.WriteLine($"\nError: {ex.Message}");
    }
}
else
{
    todoList = new TodoList();

    todoList.Add(new SOLID_Single_Responsibility_Principle.Models.TodoItem
    {
        Id = "1",
        Title = "Learn SOLID Principles",
        Description = "Understand and implement the Single Responsibility Principle.",
        IsCompleted = false
    });
    todoList.Add(new SOLID_Single_Responsibility_Principle.Models.TodoItem
    {
        Id = "2",
        Title = "Practice Coding",
        Description = "Solve problems and build projects to reinforce learning.",
        IsCompleted = false
    });

    Console.WriteLine("Created new Todo List:");
    Console.WriteLine(todoList);
}

PersistenceManager.SaveToFile(todoList, fileName, overwrite: true);